using DDD.WinForm.ViewModels;
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
    public partial class MeasureLisstView : BaseForm
    {
        public MeasureLisstView()
        {
            InitializeComponent();

            var viewModel = new MeasureListViewModel();
            //MeasureDataGrid.DataBindings.Add("DataSource", viewModel, nameof(viewModel.Measures));
            MeasureDataGrid.DataSource = viewModel.Measures;
        }
    }
}
