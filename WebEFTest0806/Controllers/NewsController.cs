
using efbLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebEFTest0806.Controllers
{
    public class NewsController : Controller
    {
        // GET: News

        NewsService newsService = new NewsService();
        public ActionResult Index()
        {

            List<News> listNews = new List<News>();
            listNews.Add(new News() { Author = "hello", SubTime = DateTime.Now.ToString(), ImagePath = "www", NewsMsg = "hi，啥啥啥", Title = "哈哈" }
          ); // return Content("Ok");
            ViewData["news"] = listNews;
            return View();
        }
    }
}