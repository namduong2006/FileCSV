using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileCSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "D:\\Code Gym\\FileCSV\\filecsv.csv"; // Đường dẫn đến tập tin CSV

            try
            {
                string[] lines = File.ReadAllLines(filePath); // Đọc tất cả các dòng từ tệp tin

                foreach (string line in lines)
                {
                    string[] parts = line.Split(','); // Tách chuỗi thành các phần tử bằng dấu phẩy

                    if (parts.Length >= 6)
                    {
                        string countryCode = parts[4].Trim('"'); // Lấy mã quốc gia
                        string countryName = parts[5].Trim('"'); // Lấy tên quốc gia

                        Console.WriteLine(countryCode + " - " + countryName);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
