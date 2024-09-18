using Microsoft.AspNetCore.Mvc;
namespace MVCMOVIE.Controllers;


public class StudentController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost] // nhận dữ liệu từ view 
    public IActionResult Index(string MaSinhVien, string HoTen)
    {
        string strResult = "Xin chao " + MaSinhVien + "-" + HoTen;
        ViewBag.Info = strResult;
        return View();
    }
}