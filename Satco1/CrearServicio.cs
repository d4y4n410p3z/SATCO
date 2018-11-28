using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satco1
{
    public partial class CrearServicio : Form
    {
        public CrearServicio()
        {
            InitializeComponent();
        }

        private void CrearServicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            PRINCIPAL.SegCrearServicio = 0;
        }
    }
}
