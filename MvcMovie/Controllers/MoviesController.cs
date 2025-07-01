using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class MoviesController : Controller
{
    // GET: /movies/
    public IActionResult Index()
    {
        return View();
    }

    // GET: /movies/welcome
    public IActionResult Welcome()
    {
        ViewData["Message"] = "This is the Welcome action method of Movies Controller";
        ViewData["NumTimes"] = 10;
        return View();
    }

    // GET: /movies/get/:id?cat=value
    public IActionResult Get(int id, string cat)
    {
        ViewData["Message"] = HtmlEncoder.Default.Encode($"This is information of movies have id = {id} with category is {cat}");
        return View();
    }
}