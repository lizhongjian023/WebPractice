using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEFDal
{
    interface IDbSession
    {
        INewsDal NewsDal { get; set; }
        INewsCommentsDal NewsCommentsDal { get; set; }
        IUserInfoDal UserInfoDal { get; set; }
    }
}
