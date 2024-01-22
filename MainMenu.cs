using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR2
{
    public partial class MainMenu :  Form, IMainView
    {
       public event Action ShowedPopulationStats;
        public MainMenu()
        {
            InitializeComponent();
        }

        

        public new void Show()
        {
            Application.Run(this);
        }
        public void DrawData(string[][] data)
        {
            float[][] dataFloat; 
            Dot[] dots = GraphicCalculactor.CalculateGraphicDots(dataFloat);
        }
        private void DrawGraphic(Dot[] dots)
        {
            for (int i = 0; i < dots.Length; i++) {
                chart1.Series[0].Points.AddXY(dots[i].X, dots[i].Y);
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ShowPopulationStats(object sender, EventArgs e)
        {
            ShowedPopulationStats?.Invoke();
        }
        
    }
}
