using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class MoviesController : Controller
{
    // GET: /movies/
    public string Index()
    {
        return "This is my default action...";
    }

    // GET: /movies/welcome
    public string Welcome()
    {
        return "This is the Welcome action method of Movies Controller";
    }

    // GET: /movies/get/:id?cat=value
    public string Get(int id, string cat)
    {
        return "This is information of movies have id = " + id.ToString() + " with category is " + cat;
    }
}