using ConnectDataBase;
using Domain;
using Newtonsoft.Json;
using QuanLyBanHang.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyBanHang.Controllers
{
    public class ProductController : CommandBaseController
    {
        // GET: Product
        public ActionResult ProductList(ProductListAction CommandAction,bool isPopup = false)
        {
            this.ViewBag.isPopup = isPopup;
            this.ViewBag.Result = CommandAction.Execute();
            return View();
        }
        
        [HttpPost]
        public ActionResult ProductList(ProductListAction CommandAction)
        {
            var products = CommandAction.Execute();
            
            List<string[]> aa = new List<string[]>();
            aa.Add(new string[] { "MaSP","Nhóm SP","Tên SP","Giá","Barcode","Số lượng"});
            products.ForEach(delegate (dynamic a)
            {
                List<string> bb = new List<string>();
                bb.Add(a.ProductId.ToString());
                bb.Add(a.CategoryName.ToString());
                bb.Add(a.ProductName.ToString());
                bb.Add(a.Price.ToString());
                bb.Add(a.Barcode.ToString());
                bb.Add(a.Qty.ToString());
                aa.Add(bb.ToArray());
            });
            var rs = aa.ToArray();

            return JsonExpando(rs);
        }

        public ActionResult PrintBarCode(ProductListAction CommandAction)
        {
            this.ViewBag.Result = CommandAction.Execute();
            return View();
        }
        public ActionResult ProductInput(ProductInputAction CommandAction)
        {
            this.ViewBag.Result = new List<dynamic>();
            if(CommandAction.ProductId != null)
            {
                this.ViewBag.Result = CommandAction.Execute();
                this.ViewBag.EditFlag = "M";
            }
            using (var cmd = new CategorySearchRepository())
            {
                this.ViewBag.Product = cmd.Exeucte();
            }
            return View();
        }
        [HttpPost]
        public ActionResult ProductExecuteDeleteById(ProductExecuteDeleteByIdAction CommandAction)
        {
            try
            {
                return JsonExpando(Success(CommandAction.Execute()));
            }
            catch (Exception ex)
            {
                return JsonExpando(Success(false,ex.Message));

            }
        }
        [HttpPost]
        public ActionResult ProductExecuteSave(ProductExecuteSaveAction CommandAction)
        {
            try
            {
                return JsonExpando(Success(CommandAction.Execute()));
            }
            catch (Exception ex)
            {
                return JsonExpando(Success(false,ex.Message));

            }
        }
        public ActionResult CategoryList(CategoryListAction CommandAction,bool isPopup = false)
        {
            this.ViewBag.isPopup = isPopup;
            this.ViewBag.Result = CommandAction.Execute();
            return View();
        }
        public ActionResult CategoryInput(CategoryInputAction CommandAction)
        {
            this.ViewBag.Result = new List<dynamic>();
            if(CommandAction.CategoryId != null)
            {
                this.ViewBag.Result = CommandAction.Execute();
                this.ViewBag.EditFlag = "M";
            }
            return View();
        }

        [HttpPost]
        public ActionResult CategoryExecuteSave(CategoryExecuteSaveAction CommandAction)
        {
            try
            {
                return JsonExpando(Success(CommandAction.Execute()));
            }
            catch (Exception ex)
            {
                return JsonExpando(Success(false, ex.Message));

            }
        }
        [HttpPost]
        public ActionResult CategoryExecuteDeleteById(CategoryExecuteDeleteByIdAction CommandAction)
        {
            try
            {
                return JsonExpando(Success(CommandAction.Execute()));
            }
            catch (Exception ex)
            {
                return JsonExpando(Success(false, ex.Message));

            }
        }
        [HttpPost]
        public ActionResult ProductGetById(ProductGetByIdAction CommandAction)
        {
            try
            {
                return JsonExpando(Success(CommandAction.Execute()));
            }
            catch (Exception ex)
            {
                return JsonExpando(Success(false, ex.Message));
            }
        }
    }
}