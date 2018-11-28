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
    public partial class IngresarMediSuperiores : Form
    {
        public IngresarMediSuperiores()
        {
            InitializeComponent();
        }

        private void IngresarMediSuperiores_FormClosing(object sender, FormClosingEventArgs e)
        {
            PRINCIPAL.SegIngresarSuperior = 0;
        }
    }
}
