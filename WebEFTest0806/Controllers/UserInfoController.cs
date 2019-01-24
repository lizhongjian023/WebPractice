using EFDal;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebEFTest0806.Models;

namespace WebEFTest0806.Controllers
{
    public class UserInfoController : Controller
    {
        UserInfoDal userInfoDal = new UserInfoDal();
        public ActionResult Index()
        {
            List<UserInfo> userInfoList = new List<UserInfo>();

            userInfoList.Add(new UserInfo { Age = 12, UserName = "hello world",  UserMail = "1234567@qq.com", UserRealName = "good " });
            userInfoList.Add(new UserInfo { Age = 13, UserName = "hello world1", UserMail = "1234567@qq.com", UserRealName = "good1" });
            userInfoList.Add(new UserInfo { Age = 14, UserName = "hello world2", UserMail = "1234567@qq.com", UserRealName = "good2" });



            ViewData["userInfoList"] = userInfoList;

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

    }
}