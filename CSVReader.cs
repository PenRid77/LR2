using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace LR2
{
     static class CSVReader
    {
        static public string[][] GetDataCSV(string filePath)
        {
            List<string[]> data = new List<string[]>();
            using (StreamReader reader = new StreamReader(filePath, Encoding.Default))
            {
                string headerLine = reader.ReadLine();
                string[] headers = headerLine.Split(';');
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(';');
                    data.Add(values);

                }
                
            }
            
            return data.ToArray();
        }
    }
}
