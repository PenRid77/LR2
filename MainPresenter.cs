﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
     class MainPresenter : IPresenter
    {
        private readonly IMainView _view;
        private readonly IMainModel _model;
        

        public MainPresenter(IMainView view, IMainModel model)
        {
            _view = view;
            _model = model;
            _view.ShowedPopulationStats += ShowPopulationStats;
        }
        public void Run()
        {
            _view.Show();
          
        
        }
        private void ShowPopulationStats()
        {
            
            string[][] data = _model.GetData("dataNaselenie.csv");
            
        }
    }
}
