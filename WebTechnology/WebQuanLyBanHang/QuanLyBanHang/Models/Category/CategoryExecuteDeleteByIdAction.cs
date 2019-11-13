using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models
{
    public class CategoryExecuteDeleteByIdAction
    {
        public int CategoryId { get; set; }
        public bool Execute()
        {
            using(var cmd = new CategoryDeleteByIdRepository())
            {
                cmd.CategoryId = this.CategoryId;
                return cmd.Execute();
            }
        }
    }
}