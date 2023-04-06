using System;
using System.IO;

namespace SaveToCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[,] data =
            {
                { "Column1", "Column2", "Column3" },
                { "Data1", "Data2", "Data3" },
                { "Data4", "Data5", "Data6" }
            };

            
            string fileName = "data.csv";
            string filePath = Path.Combine(Environment.CurrentDirectory, fileName);

            
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = 0; i < data.GetLength(0); i++)
                {
                    string[] rowData = new string[data.GetLength(1)];
                    for (int j = 0; j < data.GetLength(1); j++)
                    {
                        rowData[j] = data[i, j];
                    }
                    writer.WriteLine(string.Join(",", rowData));
                }
            }

            Console.WriteLine($"Data saved to {fileName}");
        }
    }
}