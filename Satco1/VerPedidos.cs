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
    public partial class VerPedidos : Form
    {
        public VerPedidos()
        {
            InitializeComponent();
        }

        private void VerPedidos_FormClosing(object sender, FormClosingEventArgs e)
        {
            PRINCIPAL.SegVerPedido = 0;
        }
    }
}
