using EFDal;
using EFBll;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebEFTest0806.Models;
using Common;

namespace WebEFTest0806.Controllers
{
    public class UserInfoController : Controller
    {
        UserInfoService userInfoBll = new UserInfoService();
        public ActionResult Index()
        {

            ViewData["UserList"] = userInfoBll.GetEntities(u => u.Id > 2).ToList();
            var users = ViewData["UserList"];
            return View();
        }

        public ActionResult LoadUserInfos()
        {

            var userList = userInfoBll.GetEntities(u => u.Id > 2).Select(u => new { u.UserLoginName, u.UserName, u.Id }).ToList();

            return Json(userList, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddUser()
        {

            return View();
        }

        public string AddUserInfo(Model.UserInfo userInfo)
        {

            if (userInfo.UserLoginName == "" || userInfo.UserLoginName == null)
            {

                return ViewBag.Errmsg = "no:请输入用户登录名！";
            }
            if (userInfo.Age > 120 || userInfo.Age < 0 || userInfo.Age == null)
            {
                return ViewBag.Errmsg = "no:请输入正确的年龄！";
            }
            if (userInfo.UserMail == "" || userInfo.UserMail == null)
            {
                return ViewBag.Errmsg = "no:请输入邮箱！";
            }

            if (userInfo.UserName == "" || userInfo.UserName == null)
            {
                return ViewBag.Errmsg = "no:请输入用户真实名！";
            }

            if (userInfo.UserPsd == "" || userInfo.UserPsd == null)
            {
                return ViewBag.Errmsg = "no:请输入密码！";
            }

            //  用户密码使用MD5加密
            string userPsd = userInfo.UserPsd.ToMD5();
            userInfo.UserPsd = userPsd;
            userInfo.IsUseful = 1;
            
            if (userInfoBll.Add(userInfo))
            {
                return ViewBag.Errmsg = "ok:添加成功";
            }
            else
            {
                return ViewBag.Errmsg = "ok:添加失败";
            }

        }
    }
}