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
    public class CategoryExecuteSaveBusiness : Connection
    {
        public string EditFlag { get; set; }
        public Category Item { get; set; }
        public bool Execute()
        {
            if (this.EditFlag == "M")
            {
                using (var cmd = new CategoryUpdateRepository())
                {
                    cmd.Item = this.Item;
                    return cmd.Execute();
                }
            }
            else
            {
                using (var cmd = new CategoryInsertRepository())
                {
                    cmd.Item = this.Item;
                    return cmd.Execute();
                }
            }
        }
    }
}
