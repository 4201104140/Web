using BraintreeHttp;
using PayPalCheckoutSdk.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tai.Models.CartModels;

namespace Tai.Models.CaptureIntent
{
    public class CreateOrderPayPal
    {
        private static OrderRequest BuildRequestBody(List<CartItem> carts)
        {
            var sumPrice = carts.Sum(c => c.Price);
            List<Item> items = new List<Item>();
            for(var i =0;i<carts.Count;i++)
            {
                items.Add(new Item
                {
                    Name = carts[i].Product.ProductName,
                    Description = carts[i].Product.ProductDescription.Split(".")[0],
                    Sku = "sku"+ carts[i].Product.Barcode,
                    UnitAmount = new Money
                    {
                        CurrencyCode = "USD",
                        Value = (carts[i].Product.Price/23000).ToUSD()
                    },
                    Tax = new Money
                    {
                        CurrencyCode = "USD",
                        Value = (carts[i].Product.Price/23000 * 0.1).ToUSD()
                    },
                    Quantity = carts[i].Quantity.ToString(),
                    Category = "PHYSICAL_GOODS"
                });
            }
            OrderRequest orderRequest = new OrderRequest()
            {
                CheckoutPaymentIntent = "AUTHORIZE",

                ApplicationContext = new ApplicationContext
                {
                    BrandName = "Nhom 13",
                    LandingPage = "BILLING",
                    CancelUrl = "https://localhost:44389/thanh-toan/thanh-toan-that-bai",
                    ReturnUrl = "https://localhost:44389/thanh-toan/thanh-toan-thanh-cong",
                    UserAction = "CONTINUE",
                    ShippingPreference = "SET_PROVIDED_ADDRESS"
                },
                PurchaseUnits = new List<PurchaseUnitRequest>
                {
                    new PurchaseUnitRequest{
                        ReferenceId =  "PUHF",
                        Description = "Phan Tan Tai",
                        CustomId = "CUST-HighFashions",
                        SoftDescriptor = "HighFashions",
                        AmountWithBreakdown = new AmountWithBreakdown
                        {
                            CurrencyCode = "USD",
                            Value = (sumPrice/23000*1.1+0.0).ToUSD(),
                            AmountBreakdown = new AmountBreakdown
                            {
                                ItemTotal = new Money
                                {
                                    CurrencyCode = "USD",
                                    Value = (sumPrice/23000).ToUSD()
                                },
                                Shipping = new Money
                                {
                                    CurrencyCode = "USD",
                                    Value = "0.00"
                                },
                                Handling = new Money
                                {
                                    CurrencyCode = "USD",
                                    Value = "0.00"
                                },
                                TaxTotal = new Money
                                {
                                    CurrencyCode = "USD",
                                    Value = (sumPrice/23000*0.1).ToUSD()
                                },
                                ShippingDiscount = new Money
                                {
                                    CurrencyCode = "USD",
                                    Value = "0.00"
                                }
                            }
                        },
                        Items = items,
                        ShippingDetail = new ShippingDetail
                        {
                            Name = new Name
                            {
                                FullName = "Nhóm 13"
                            },
                            AddressPortable = new AddressPortable
                            {
                                AddressLine1 = "123 Townsend St",
                                AddressLine2 = "Floor 6",
                                AdminArea2 = "San Francisco",
                                AdminArea1 = "CA",
                                PostalCode = "94107",
                                CountryCode = "US"
                            }
                        }
                    }
                }
            };

            return orderRequest;
        }

        //Below function can be used to create an order with complete payload.
        public async static Task<HttpResponse> CreateOrder(List<CartItem> carts)
        {
            var request = new OrdersCreateRequest();
            request.Prefer("return=representation");
            request.RequestBody(BuildRequestBody(carts));
            var response = await PayPalClient.client().Execute(request);
            var result = response.Result<Order>();
            
            return response;
        }

        //Below function can be used to build the create order request body with minimum payload.
        private static OrderRequest BuildRequestBodyWithMinimumFields()
        {
            OrderRequest orderRequest = new OrderRequest()
            {
                CheckoutPaymentIntent = "AUTHORIZE",
                ApplicationContext = new ApplicationContext
                {
                    CancelUrl = "https://www.example.com",
                    ReturnUrl = "https://www.example.com"
                },
                PurchaseUnits = new List<PurchaseUnitRequest>
                {
                    new PurchaseUnitRequest{
                        AmountWithBreakdown = new AmountWithBreakdown
                        {
                            CurrencyCode = "USD",
                            Value = "220.00"
                        }

                    }
                }
            };

            return orderRequest;
        }

        //Below function can be used to create an order with minimum payload.
        public async static Task<HttpResponse> CreateOrderWithMinimumFields()
        {
            Console.WriteLine("Create Order with minimum payload..");
            var request = new OrdersCreateRequest();
            request.Headers.Add("prefer", "return=representation");
            request.RequestBody(BuildRequestBodyWithMinimumFields());
            var response = await PayPalClient.client().Execute(request);
            return response;
        }
    }
}
