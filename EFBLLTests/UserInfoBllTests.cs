using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using EFBll;

namespace efbLL.Tests
{
    [TestClass()]
    public class UserInfoServiceTests
    {
        [TestMethod()]
        public void AddTest()
        {
            UserInfo userInfo = new UserInfo() { Age = 12,CrUserName = "",UserLoginName = "lizj",UserName= "李中建", CrDate=DateTime.Now,IsOnLine=0,IsUseful=1,IsVip =1,UserMail="153126453@qq.com" ,CrUserRealName="李中建",UserPsd = "1234567890",UserRealName = "李中建"};


            UserInfoService UserInfoService = new UserInfoService();
            if (UserInfoService.Add(userInfo))
            {

            }
            else
            {
                Assert.Fail();
            }
          
        }


        [TestMethod]
        public void AddUserInfo()
        {
            UserInfo userInfo = new UserInfo() { Age = 12, CrUserName = "", UserLoginName = "lizj", UserName = "李中建", CrDate = DateTime.Now, IsOnLine = 0, IsUseful = 1, IsVip = 1, UserMail = "153126453@qq.com", CrUserRealName = "李中建", UserPsd = "1234567890", UserRealName = "李中建" };

            UserInfoService userInfoService = new UserInfoService();
            if (userInfoService.Add(userInfo))
            {
            }
            else
            {
                Assert.Fail();
            }

        }


        [TestMethod]

        public void GetUserInfos()
        {
            UserInfoService userInfoService = new UserInfoService();
            var users = userInfoService.GetEntities(u => true);
            if (users.Count() > 0 ? true : false)
            {
                
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}