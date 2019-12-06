using ConnectDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleRepository.Sale
{
    public class SaleGetByDateRepository:Connection
    {
        public DateTime SaleDate { get; set; }
        public List<dynamic> Execute()
        {
            using(var cmd=new Query())
            {
                cmd.QueryString = "select Sale.*,Employee.EmployeeName,Customer.CustomerName,SUM(SaleItem.Qty) as Qty from Sale left join SaleItem on SaleItem.SaleId = Sale.SaleId left join Product on Product.ProductId = SaleItem.ProductId left join Customer on Customer.CustomerId = Sale.CustomerId left join Employee on Employee.EmployeeId = Sale.EmployeeId WHERE Sale.SaleDate='"+ SaleDate +"'group by Sale.SaleId,Sale.CustomerId,Sale.EmployeeId,Sale.SaleDate,Sale.Total,Customer.CustomerName,Employee.EmployeeName,Sale.Status,Sale.Note";
                return cmd.ExecuteQuery();
            }
        }
    }
}
