using ConnectDataBase;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CategoryInsertRepository : Connection
    {
        public Category Item { get; set; }
        string RandStr()
        {
            var chars = "abcdefghijklmnopqrstuvwxyz";
            var stringChars = new char[4];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new String(stringChars);
        }
        public bool Execute()
        {
            using(var cmd = new Query())
            {
                cmd.QueryString = "INSERT INTO [dbo].[Category]([CategoryId] ,[CategoryName] ,[CategoryParentId] ,[CategoryRemark]) VALUES (N'"+RandStr()+"',N'" + Item.CategoryName + "', N'"+Item.CategoryParentId+"',N'" + Item.CategoryRemark + "')";
                return cmd.ExecuteQueryNonReader();
            }
        }
    }
}
