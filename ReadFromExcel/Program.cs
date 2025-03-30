using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleReadExcel
{
    public static class Utils
    {
        public static DataTable GetPage(this DataSet dataSet, int pageNumber)
        {
            return dataSet.Tables[pageNumber - 1];
        }

        public static DataRow GetRow(this DataTable dataTable, int rowNumber)
        {
            return dataTable.Rows[rowNumber - 1];
        }

        public static string GetColumn(this DataRow row, char columnLetter)
        {
            int index = (int)columnLetter - (int)'A';
            var item = row[index];
            return item.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\Book1.xlsx";
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            using (StreamReader stream = new StreamReader(filePath))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream.BaseStream))
                {
                    DataSet excellDataSet = reader.AsDataSet(new ExcelDataSetConfiguration());

                    int page = 1;
                    int rowsStart = 6;
                    char columnLetter = 'B';

                    int rowsCount = excellDataSet.GetPage(page).Rows.Count;

                    for (int row = rowsStart; row <= rowsCount; row++)
                    {
                        var value = excellDataSet.GetPage(page).GetRow(row).GetColumn(columnLetter);
                        Console.WriteLine(value);
                    }
                }
            }
        }
    }
}