using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Shop.Models
{
    public static class Helper
    {
        public static string ToUrlFriendly(this string stri)
        {
            string str = stri.ToLower().Trim();

            str = Regex.Replace(str, @"[aáàảãạâấầẩẫậăắằẳẵặ]", "a");
            str = Regex.Replace(str, @"[đ]", "d");
            str = Regex.Replace(str, @"[eéèẻẽẹêếềểễệ]", "e");
            str = Regex.Replace(str, @"[iíìỉĩị]", "i");
            str = Regex.Replace(str, @"[oóòỏõọôốồổỗộơớờởỡợ]", "o");
            str = Regex.Replace(str, @"[uúùủũụưứừửữự]", "u");
            str = Regex.Replace(str, @"\s+", "-").Trim();
            str = Regex.Replace(str, @"\s", "-");

            return str;
        }
    }
}
