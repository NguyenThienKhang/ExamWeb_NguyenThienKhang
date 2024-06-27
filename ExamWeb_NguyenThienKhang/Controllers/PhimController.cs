using ExamWeb_NguyenThienKhang.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWeb_NguyenThienKhang.Controllers
{
    public class PhimController : Controller
    {
        private readonly ApplicationDbContext _db;
        public PhimController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var listPhim = _db.phims.ToList();
            return View(listPhim);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Phim phim)
        {
            if (ModelState.IsValid)
            {
                _db.phims.Add(phim);
                _db.SaveChanges();
         
            
          TempData["success"] = "Thêm phim thành công";
                return RedirectToAction("Index");
            }
            return View();
        }
        //Hiển thị form cập nhật chủng loại
        public IActionResult Update(int id)
        {
            var phims = _db.phims.Find(id);
            if (phims == null)
            {
                return NotFound();
            }
            return View(phims);
        }
        // Xử lý cập nhật chủng loại
        [HttpPost]
        public IActionResult Update(Phim phim)
        {
            if (ModelState.IsValid) //kiem tra hop le
            {
                //cập nhật category vào table Categories
                _db.phims.Update(phim);
                _db.SaveChanges();
                TempData["success"] = "Cập nhật phim thành công";
                return RedirectToAction("Index");
            }
            return View();
        }
        //Hiển thị form xác nhận xóa chủng loại
        public IActionResult Delete(int id)
        {
            var p = _db.phims.FirstOrDefault(x => x.Id == id);
            if (p == null)
            {
                return NotFound();
            }
            return View(p);
        }
        // Xử lý xóa chủng loại
        public IActionResult DeleteConfirmed(int id)
        {
            var category = _db.phims.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            _db.phims.Remove(category);
            _db.SaveChanges();
            TempData["success"] = "Xoá phim thành công";
            return RedirectToAction("Index");
        }
    }
}
