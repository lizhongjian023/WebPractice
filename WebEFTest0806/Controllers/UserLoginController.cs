using Common;
using EFBll;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebEFTest0806.Controllers
{
    public class UserLoginController : Controller
    {
        // GET: UserLogin
        UserInfoService userInfoService = new UserInfoService();
        public ActionResult Index()
        {
          
            return View();
        }

        public ActionResult UserLogin()
        {

            string userName = Request["loginName"];
            string loginPsd = Request["loginPsd"];
           
            if (string.IsNullOrWhiteSpace(userName))
            {
                return Content("no:请输入用户名！");
            }
            if (string.IsNullOrWhiteSpace(loginPsd))
            {
                return Content("no:请输入密码！");
            }
            string psd = loginPsd.ToMD5();
            UserInfo userInfos = userInfoService.GetEntities(u => u.UserLoginName == userName.ToString().Trim() && u.UserPsd == psd && u.IsUseful == 1).FirstOrDefault<UserInfo>();
            if (userInfos != null)     //登陆成功
            {
                 return Content("ok:恭喜，登陆成功！");  
            }
            else
            {
                 return Content("no:傻叉，你会登陆吗？");
            }
        }
    }
}