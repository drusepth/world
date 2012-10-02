using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace World
{
    public partial class frmWorldController : Form
    {
        public frmWorldController()
        {
            InitializeComponent();
        }

        private void frmWorldController_Load(object sender, EventArgs e)
        {
            World world = new World();
        }

    }
}
