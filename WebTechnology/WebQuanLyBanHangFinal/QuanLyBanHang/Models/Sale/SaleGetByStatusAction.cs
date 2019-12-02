using SaleRepository.Sale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models
{
    public class SaleGetByStatusAction
    {
        public int Status { get; set; }
        public List<dynamic> Execute()
        {
            using(var cmd=new SaleGetByStatusRepository())
            {
                cmd.Status = this.Status;
                return cmd.Execute();
            }
        }
    }
}