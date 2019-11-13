using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repository;
namespace QuanLyBanHang.Models
{
    public class CategoryInputAction
    {
        public string CategoryId { get; set; }
        public List<dynamic> Execute()
        {
            using(var cmd = new CategoryGetByIdRepository())
            {
                cmd.CategoryId = this.CategoryId;
                return cmd.Execute();
            }
        }
    }
}