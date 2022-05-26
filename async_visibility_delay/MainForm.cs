using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace async_visibility_delay
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            makeVisibleOnDelay();
        }

        private async void makeVisibleOnDelay()
        {
            await Task.Delay(1000);
            panel1.Visible = true;
            await Task.Delay(1000);
            panel2.Visible = true;
        }
    }
}
