using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
     class MainModel : IMainModel
    {

        public string[][] GetData(string filePath)
        {
            string dataPath = "..\\..\\Data\\" + filePath;
            string[][] data = CSVReader.GetDataCSV(dataPath);
            return data;
        }

    }
}
