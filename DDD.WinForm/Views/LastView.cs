﻿using DDD.WinForm.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDD.WinForm.Views
{
    public partial class LastView : BaseForm
    {
        public LastView()
        {
            InitializeComponent();
            var viewModel = new LatestViewModel();
            this.DataBindings.Add("Text", viewModel, nameof(viewModel.MeasureDate));
            this.MeasureViewLabel.DataBindings.Add("Text", viewModel, nameof(viewModel.MeasureValue));
        }
    }
}
