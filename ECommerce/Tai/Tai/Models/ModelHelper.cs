using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tai.Models
{
    public static class ModelHelper
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
            str = Regex.Replace(str, @"[^a-z0-9\s-]", "");
            str = Regex.Replace(str, @"\s+", "-").Trim();
            str = Regex.Replace(str, @"\s", "-");

            return str;
        }
        public static string ToVnC(this double money)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            string a = money.ToString("#,###đ", cul.NumberFormat);
            return a;
        }
    }
}
