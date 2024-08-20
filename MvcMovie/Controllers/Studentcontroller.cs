using Microsoft.AspNetCore.Mvc;
namespace MVC.Controllers;


public class StudentController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(string MaSinhVien, string HoTen)
    {
        string strResult = "Xin chao " + MaSinhVien + "-" + HoTen;
        ViewBag.Info = strResult;
        return View();
    }
}