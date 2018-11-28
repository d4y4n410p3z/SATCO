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
    public partial class RegistrarPedido : Form
    {
        public RegistrarPedido()
        {
            InitializeComponent();
        }

        private void RegistrarPedido_FormClosing(object sender, FormClosingEventArgs e)
        {
            PRINCIPAL.SegRegistrarPedido = 0;
        }
    }
}
