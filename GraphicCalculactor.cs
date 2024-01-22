using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    static class GraphicCalculactor
    {
        static public Dot[] CalculateGraphicDots(float[][] data)
        {
            List<Dot> dots = new List<Dot>();
            for (int i = 0; i < data.Length; i++)
            {
               
                    Dot dot = new Dot(data[i][0], data[i][1]);
                    dots.Add(dot);
            }
            return dots.ToArray();

        }
    }
}
