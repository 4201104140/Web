using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BraintreeHttp;
using Microsoft.AspNetCore.Mvc;
using PayPal.Core;
using PayPal.v1.Payments;
using Shop.Helper;
using Shop.Models;

namespace Shop.Controllers
{
    public class PayPalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public List<CartItem> Cart
        {
            get
            {
                var data = HttpContext.Session.GetObject<List<CartItem>>("Cart");
                if (data == null)
                {
                    data = new List<CartItem>();
                }

                return data;
            }
        }

        public async Task<IActionResult> Test()
        {
            var environment = new SandboxEnvironment("AY8MwYgaL5KnJtJ-vx4G1cwgxcDg5dYUCQQTJZHJJZZMiJlDK53Uqvy6n1iCgff23iwfOxPsZ0TmZ3IS", "ENxga6p6gERlitpbUG8oxAINJdw27ce_Elurr1lioQd_SWrJwFR-Puim57pGYPgLhslFgFZUrxRPack0");
            var client = new PayPalHttpClient(environment);

            var payment = new Payment()
            {
                Intent = "sale",
                Transactions = new List<Transaction>()
                {
                    new Transaction()
                    {
                        Amount = new Amount()
                        {
                            Total = "10",
                            Currency = "USD"
                        }
                    }
                },
                RedirectUrls = new RedirectUrls()
                {
                    CancelUrl = "https://example.com/cancel",
                    ReturnUrl = "https://example.com/return"
                },
                
                Payer = new Payer()
                {
                    PaymentMethod = "paypal"
                }
            };

            PaymentCreateRequest request = new PaymentCreateRequest();
            request.RequestBody(payment);

            try
            {
                HttpResponse response = await client.Execute(request);
                var statusCode = response.StatusCode;
                Payment result = response.Result<Payment>();

                var link = result.Links.GetEnumerator();
                string paypalRedirectUrl = null;
                while (link.MoveNext())
                {
                    LinkDescriptionObject lnk = link.Current;
                    if (lnk.Rel.ToLower().Trim().Equals("approval_url"))
                    {
                        paypalRedirectUrl = lnk.Href;
                    }
                }
                return Redirect(paypalRedirectUrl);
            }
            catch (HttpException httpException)
            {
                var statusCode = httpException.StatusCode;
                var debugId = httpException.Headers.GetValues("PayPal-Debug-Id").FirstOrDefault();
            }
            return View();
        }

        public async Task<IActionResult> CheckOut()
        {
            var environment = new SandboxEnvironment("AS0kSYMcJkI2Fkiog9fsFbZmvmHB_f77kUMvbeV3AhPRyoRpNOfgpHVjHAOojYiQwPSJ5yqXORY3Ri5K", "EBohfZ1jqyXHhQ5VUvaW29D_5pgv35NPsh5s6FI39FjlbAyp6lcJLgxpkX7mip-qs4Vnap2eNNWi9WtN");
            var client = new PayPalHttpClient(environment);
            var itemList = new ItemList()
            {
                Items = new List<Item>()
            };
            double sum = 0;
            foreach(var item in Cart)
            {
                itemList.Items.Add(new Item()
                {
                    Name = item.HangHoa.TenHh,
                    Currency = "USD",
                    Price = item.ThanhTien.ToString(),
                    Quantity = (item.SoLuong).ToString(),
                    Sku = "sku",
                    Tax = "0"
                });
                sum += item.ThanhTien;
            }

            var payment = new Payment()
            {
                Intent = "sale",
                Transactions = new List<Transaction>()
                {
                    new Transaction()
                    {
                        Amount = new Amount()
                        {
                            Total = sum.ToString(),
                            Currency = "USD",
                            Details = new AmountDetails()
                            {
                                Tax = "0",
                                Shipping = "0",
                                Subtotal = sum.ToString()
                            }
                        },
                        ItemList = itemList,
                        Description = "Đơn hàng",
                        InvoiceNumber = DateTime.Now.Ticks.ToString()
                    }
                },
                RedirectUrls = new RedirectUrls()
                {
                    CancelUrl = "http://localhost:44323/Paypal/Fail",
                    ReturnUrl = "http://localhost:44323/Paypal/Success"
                },
                Payer = new Payer()
                {
                    PaymentMethod = "paypal"
                }
            };

            PaymentCreateRequest request = new PaymentCreateRequest();
            request.RequestBody(payment);
            try
            {
                HttpResponse response = await client.Execute(request);
                var statusCode = response.StatusCode;
                Payment result = response.Result<Payment>();

                var link = result.Links.GetEnumerator();
                string paypalRedirectUrl = null;
                while (link.MoveNext())
                {
                    LinkDescriptionObject lnk = link.Current;
                    if (lnk.Rel.ToLower().Trim().Equals("approval_url"))
                    {
                        paypalRedirectUrl = lnk.Href;
                    }
                }
                return Redirect(paypalRedirectUrl);
            }
            catch(HttpException ex)
            {
                var statusCode = ex.StatusCode;
                var debugId = ex.Headers.GetValues("PayPal-Debug-Id").FirstOrDefault();

                return RedirectToAction("Fail");
            }
        }
        public IActionResult Success(string paymentId, string token, string payerId)
        {
            return Content("Thanh toan tc");
        }
    }
}