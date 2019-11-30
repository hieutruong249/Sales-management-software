using DAO;
using DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace BUS
{
    public class UserBUS
    {
        UserDAO usD = new UserDAO();
        public int InsertUser(User us)
        {
            us.Password = GetMD5(GetMD5(us.Password) + GetMD5(us.Username));
            string[] date = us.DoB.Split('/');
            us.DoB = date[1] + "/" + date[0] + "/" + date[2];
            return usD.InsertUser(us);
        }

        public int IsLoginSuccess(User us)
        {
            us.Password = GetMD5(GetMD5(us.Password) + GetMD5(us.Username));
            return usD.IsLoginSuccess(us);
        }

        public UserInfo UsrRolFrm(User us)
        {
            return usD.UsrRolFrm(us);
        }


        public string GetMD5(string str)
        {
            MD5 md = MD5.Create();
            byte[] Arr = System.Text.Encoding.ASCII.GetBytes(str);
            Arr = md.ComputeHash(Arr);

            StringBuilder sb = new StringBuilder();

            foreach (byte b in Arr)
            {
                sb.Append(b.ToString("X2"));
            }
            return sb.ToString();
        }


        
        
        
    }
}
