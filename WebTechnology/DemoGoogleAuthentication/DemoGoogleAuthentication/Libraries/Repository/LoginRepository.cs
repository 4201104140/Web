using DemoGoogleAuthentication.Libraries.ConnectDb;
using DemoGoogleAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoGoogleAuthentication.Libraries.Repository
{
    public class LoginRepository : Connection
    {
        public User data { get; set; } 
        public bool Execute()
        {
            using(var cmd = new Query())
            {
                cmd.QueryString = $"Select [User].[UserId] from [User] where [User].[UserId] = {data.UserId}";
                var count = cmd.ExecuteQuery();
                if (count.Count == 0)
                {
                    cmd.QueryString = $"Insert into [User] values ('{data.UserId}',N'{data.UserName}',N'{data.UserEmail}',N'{data.UserImage}',N'{data.UserToken}',{data.UserAge})";
                    return cmd.ExecuteQueryNonReader();
                }
                else
                {
                    cmd.QueryString = $"Update [User] set UserName=N'{data.UserName}',UserToken=N'{data.UserToken}',UserImage=N'{data.UserImage}'";
                    return cmd.ExecuteQueryNonReader();
                }
            }
        }
    }
}