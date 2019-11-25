using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tai.DataModels
{
    public class Mykey
    {
        public Facebook Facebook { get; set; }
    }
    public class Facebook
    {
        public string PageAccessToken { get; set; }
    }
}
