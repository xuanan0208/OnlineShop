using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Framework;
using System.Data.SqlClient;

namespace Models
{
   public class AccountModel
    {
       private OnlineShopDBContext context=null;
       public AccountModel()
       {
           context = new OnlineShopDBContext();
       }
       public bool Login(string UserName, string Password)
       {
           object[] sqlParams = 
               {
                   new SqlParameter("@UserName",UserName),
                    new SqlParameter("@Password",Password),
               };
           var res = context.Database.SqlQuery<bool>("sp_Account_Login @UserName,@Password",sqlParams).SingleOrDefault();
           return res;
       }
    }
}
