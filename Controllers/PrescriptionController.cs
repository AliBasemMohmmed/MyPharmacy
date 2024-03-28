using Microsoft.AspNetCore.Mvc;
using MyPharmacy.Models;

namespace MyPharmacy.Controllers
{
    public class PrescriptionController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PrescriptionViewModel model)
        {
            // يمكنك هنا إضافة المنطق لحفظ الوصفة في قاعدة البيانات
            return RedirectToAction("Index", "Home"); // انتقال إلى صفحة رئيسية أخرى بعد الإنشاء
        }
    }
}
