using Microsoft.AspNetCore.Mvc;
namespace MVC.Controllers;

using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MVC.Controllers;
public class StudentController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(string MaSinhVien, string HoTen)
    {
        string strResult = "Xin chào " + MaSinhVien + " - " + HoTen;
        ViewBag.Student = strResult;
        return View();
    }
}