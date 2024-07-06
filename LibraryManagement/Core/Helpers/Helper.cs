using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Core.Helpers
{
    public static class Helper
    {
        //convert dictionary to object
        public static T DictToObj<T>(IDictionary<string, object> source) where T : class, new()
        {
            try
            {
                var obj = new T();
                var objType = obj.GetType();

                foreach (var item in source)
                {
                    //Console.WriteLine(objType.GetProperty(item.Key));
                    objType.GetProperty(item.Key).SetValue(obj, item.Value, null);
                }

                return obj;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }

        public static string TruncateWithEllispsis(string str , int maxChars = 35)
        {
            return str.Length <= maxChars ? str : str.Substring(0, maxChars) + "...";
        }
    }
}
