namespace MyPharmacy.Models;
public class PrescriptionViewModel
{
    public string? PatientName { get; set; }
    public IFormFile? IdCardImage { get; set; }
    public IFormFile? PatientImage { get; set; }
    public string? PreviousPrescriptionImage { get; set; }
    public int? PatientAge { get; set; }
    public string? Diagnosis { get; set; }
    // يمكنك إضافة المزيد من الحقول حسب الحاجة
}