using BraintreeHttp;
using PayPalCheckoutSdk.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tai.Models.CartModels;

namespace Tai.Models.CaptureIntent
{
    public class CreateOrder
    {

        private static OrderRequest BuildRequestBody(List<CartItem> carts)
        {
            var items = new List<Item>();
            foreach(var cart in carts)
            {
                var item = new Item
                {
                    Name = cart.Product.ProductName,
                    Quantity = cart.Quantity.ToString(),
                    Sku = "sku",
                    UnitAmount = new Money
                    {
                        CurrencyCode = "USD",
                        Value = cart.Price.ToString()
                    }

                };
            }
            OrderRequest orderRequest = new OrderRequest()
            {
                CheckoutPaymentIntent = "CAPTURE",
                ApplicationContext = new ApplicationContext
                {
                    BrandName = "NHOM13",
                    LandingPage = "BILLING",
                    CancelUrl = "https://www.example.com",
                    ReturnUrl = "https://localhost:44389/PayPal/Access",
                    UserAction = "CONTINUE"
                },
                PurchaseUnits = new List<PurchaseUnitRequest>
                {
                    new PurchaseUnitRequest
                    {
                        ReferenceId = "PUHF",
                        Description = "Thank for billing",
                        SoftDescriptor = "Hight",
                        AmountWithBreakdown = new AmountWithBreakdown
                        {
                            CurrencyCode = "USD",
                            Value = carts.Sum(c=>c.Price).ToString(),
                            AmountBreakdown = new AmountBreakdown
                            {
                                ItemTotal = new Money
                                {
                                    CurrencyCode = "USD",
                                    Value = carts.Sum(c=>c.Price).ToString()
                                }
                            }
                        },
                        Items = items
                    }
                }
            };
            return orderRequest;
        }

        public async static Task<HttpResponse> CreateOrders(List<CartItem> carts)
        {
            
            var request = new OrdersCreateRequest();
            request.Headers.Add("prefer", "return=representation");
            request.RequestBody(BuildRequestBody(carts));
            var response = await PayPalClient.client().Execute(request);
            return response;
        }
    }
}
