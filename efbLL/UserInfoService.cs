using EFBLL;
using EFDal;
using IEFBll;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFBll
{
    public class UserInfoService : BaseService<UserInfo>, IUserInfoService

    {
        // UserInfoDal userInfoDal = new UserInfoDal();

        ///// <summary>
        ///// 新增用户信息
        ///// </summary>
        ///// <param name="userInfo"></param>
        ///// <returns></returns>
        //public bool Add(UserInfo userInfo)
        //{
        //    return userInfoDal.Add(userInfo) > 0 ? true : false;
        //}

    }
}
