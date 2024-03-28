using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyPharmacy.Models;

namespace MyPharmacy.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Doctor()
    {
        // بيانات الطبيب
        var doctor = new Doctor
        {
            Name = "عبد المجيد منعم الشمري",
            Specialization = "اختصاصي مفاصل"
        };

        return View(doctor);
    }
    // انشاء وصفه
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
#pragma warning disable IDE0060 // Remove unused parameter
    public IActionResult Create(PrescriptionViewModel model)
#pragma warning restore IDE0060 // Remove unused parameter
    {
        // يمكنك هنا إضافة المنطق لحفظ الوصفة في قاعدة البيانات
        return RedirectToAction("Index", "Home"); // انتقال إلى صفحة رئيسية أخرى بعد الإنشاء
    }
    public IActionResult regester()
    {
        return View();
    }
     [HttpPost]
     public IActionResult regester(PrescriptionViewModel model)
    {
        return RedirectToAction("Index", "Home");
    }

}
