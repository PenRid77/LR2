using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
     interface IMainView : IView
    {
        event Action ShowedPopulationStats;
        void DrawData(string[][] data);


    }
}
