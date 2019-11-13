using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models
{
    public class CategoryListAction
    {
        public bool isChild { get; set; }
        public List<dynamic> Execute()
        {
            using (var cmd = new CategorySearchRepository())
            {
                return cmd.Exeucte();
            }
        }
    }
}