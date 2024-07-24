using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LibraryManagement.Core.Helpers
{
    public class FileHelper
    {
        public static readonly string UserBookFile = "C:\\Users\\User\\source\\repos\\LibraryManagement\\LibraryManagement\\userbook.json";

        
        public static bool SaveListToJson<T>(List<T> listItems , string filePath)
        {
            bool res = false;
            try
            {
                string json = JsonSerializer.Serialize(listItems);
                File.WriteAllText(filePath, json);
                res = true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                res = false;
            }
            return res;
        }

        public static List<T>? JsonToList<T>(string filePath)
        {
            string json = File.ReadAllText(filePath);
            var result = JsonSerializer.Deserialize<List<T>>(json);
            return result;
        }
    }
}
