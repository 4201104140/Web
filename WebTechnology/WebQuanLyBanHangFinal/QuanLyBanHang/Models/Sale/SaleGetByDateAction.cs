using SaleRepository.Sale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models
{
    public class SaleGetByDateAction
    {
        public DateTime SaleDate { get; set; }
        public List<dynamic> Execute()
        {
            using(var cmd=new SaleGetByDateRepository())
            {
                cmd.SaleDate = this.SaleDate;
                return cmd.Execute();
            }
        }
    }
}