using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyBanHang.Controllers
{
    public class ExcelController : CommandBaseController
    {
        // GET: Excel
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SaleStatistical(SaleGetByDateAction CommandAction)
        {
            var products = CommandAction.Execute();

            List<string[]> aa = new List<string[]>();
            aa.Add(new string[] { "Mã hoá đơn", "Ngày hoá đơn", "Tên nhân viên", "Tên khách hàng", "Số lượng", "Tổng tiền", "Trạng thái" });
            products.ForEach(delegate (dynamic a)
            {

                List<string> bb = new List<string>();
                bb.Add(a.SaleId.ToString());
                bb.Add(a.SaleDate.ToString());
                bb.Add(a.CustomerName.ToString());
                bb.Add(a.CustomerName.ToString());
                bb.Add(a.Qty.ToString());
                bb.Add(a.Total.ToString());
                bb.Add(a.Status.ToString());
                aa.Add(bb.ToArray());
            });
            var rs = aa.ToArray();

            return JsonExpando(rs);
        }
        [HttpPost]
        public ActionResult SaleStatisticalByStatus(SaleGetByStatusAction CommandAction)
        {
            var sale = CommandAction.Execute();
            foreach(var item in sale)
            {
                if (item.Status == 1)
                {
                    item.Status = "Đã hoàn thành";
                }
                else
                {
                    item.Status = "Chưa xử lí";
                }
                item.SaleDate = Convert.ToDateTime(item.SaleDate).ToString("yyyy-MM-dd");
            }
            List<string[]> aa = new List<string[]>();
            aa.Add(new string[] { "Mã hoá đơn", "Ngày hoá đơn", "Tên nhân viên", "Tên khách hàng", "Số lượng", "Tổng tiền", "Trạng thái" });
            sale.ForEach(delegate (dynamic a)
            {

                List<string> bb = new List<string>();
                bb.Add(a.SaleId.ToString());
                bb.Add(a.SaleDate.ToString());
                bb.Add(a.CustomerName.ToString());
                bb.Add(a.CustomerName.ToString());
                bb.Add(a.Qty.ToString());
                bb.Add(a.Total.ToString());
                bb.Add(a.Status.ToString());
                aa.Add(bb.ToArray());
            });
            var rs = aa.ToArray();

            return JsonExpando(rs);
        }
    }
}