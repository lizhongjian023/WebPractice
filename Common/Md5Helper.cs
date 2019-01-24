using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Common
{

    public static class Md5Helper
    {

        /// <summary>
        /// 获取字符串的MD5值
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToMD5( this string str)
        {
                           //将字符序列化
                byte[] result = System.Text.Encoding.Default.GetBytes(str);

                MD5 md5 = new MD5CryptoServiceProvider();

                //计算数组的哈希值
                byte[] hshresult = md5.ComputeHash(result);

                string strpass = "";

                for (int i = 0; i < hshresult.Length; i++)
                {
                    strpass += hshresult[i].ToString("x");
                }
                return strpass;
        }
    }
}
