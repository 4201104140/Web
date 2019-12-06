using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectDataBase;
using Domain;

using Repository;


namespace Business
{
    public class SaleItemExecuteSaveBusiness : Connection
    {
        public List<SaleItem> Item { get; set; }
        public bool Execute()
        {
            try
            {
                //Đánh dấu đã xóa hay chưa
                //var flag = false;
                
                foreach (var item in Item)
                {
                    var updateqty = new SaleItemChangeQty(item.ProductId,item.Qty,item.SaleId);

                    using (var cmd = new SaleItemDeleteBySaleIdRepository())
                    {
                        cmd.SaleItemId = item.SaleItemId;
                        cmd.SaleId = item.SaleId;
                        //if (!flag)
                        //{
                            cmd.Execute();
                        //    flag = true;
                        //}
                    }
                    //if (flag)
                    //{
                        using (var cmd = new SaleItemInsertRepository())
                        {
                            cmd.Item = item;
                            cmd.Execute();
                        }
                    //}
                    //else
                    //{
                      //return false;
                    //}
                }
                using(var cmd=new SaleUpdateTotalRepository())
                {
                    cmd.Item = Item[0];
                    cmd.Excute();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
