using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog_Project_MVC.Controllers
{
    public class BlogController : Controller
    {
        newdbEntities nd = new newdbEntities();
        // GET: Blog
        public ActionResult Index()
        {
            var blogdetails = nd.Blogs.ToList().OrderByDescending(x=>x.Bid);
            return View(blogdetails);
        }

        public ActionResult Uploadblog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Uploadblog(Blog bg)
        {
            nd.Blogs.Add(bg);
            nd.SaveChanges();
            ViewBag.message = "Blog Details Are Saved Successfully ..!";
            return View();
        }
        public ActionResult Food()
        {
            var foodarticle = nd.Blogs.Where(x => x.Bcatagory == "Food");
            return View(foodarticle);
        }

        public ActionResult Sports()
        {
            var Sportsarticle = nd.Blogs.Where(x => x.Bcatagory == "Sports");
            return View(Sportsarticle);
        }
        public ActionResult Movies()
        {
            var moviesarticles = nd.Blogs.Where(x => x.Bcatagory == "Movies");
            return View(moviesarticles);
        }
        public ActionResult Recipesworld()
        {
            return View();
        }
    }
}