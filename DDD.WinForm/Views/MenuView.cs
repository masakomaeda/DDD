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
    public partial class MenuView : BaseForm
    {
        public MenuView()
        {
            InitializeComponent();
        }

        private void MeasureButton_Click(object sender, EventArgs e)
        {
            using var f = new MeasureView();
            f.ShowDialog();
        }

        private void LatestButton_Click(object sender, EventArgs e)
        {
            using var f = new LastView();
            f.ShowDialog();
        }
    }
}
