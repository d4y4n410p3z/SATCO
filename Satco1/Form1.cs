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
   
    public partial class PRINCIPAL : Form
    {

        RegistrarCliente a;
        VeryActualizarCliente b;
        IngresarMediSuperiores c;
        IngresarMediInferiores d;
        ActualizarSuperiores z;
        ActualizarInferiores f;
        RegistrarPedido g;
        VerPedidos h;
        RegistrarVenta i;
        VerVentas j;
        CrearServicio k;
        ActualizarServicio l;
        Ayuda m;



        public static int SegRCliente = 0;
        public static  int SegActualizarClient=0;
        public static int SegIngresarSuperior = 0;
        public static int SegIngresarInfer = 0;
        public static int SegActualizarSUP = 0;
        public static int segActualizarINFER = 0;
        public static int SegRegistrarPedido = 0;
        public static int SegVerPedido = 0;
        public static int SegRegistrarVent = 0;
        public static int SegVerVenta = 0;
        public static int SegCrearServicio = 0;
        public static int SegActualizarServic = 0;
        public static int SegVerAyuda = 0;

        public PRINCIPAL()
        {
            InitializeComponent();
        }

        private void rEGISTRARCLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SegRCliente == 0)
            {
                RegistrarCliente a = new RegistrarCliente();
                a.MdiParent = this;
                a.Show();
                SegRCliente = 1;
            }
        }

        private void vERYACTUALIZARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SegActualizarClient == 0)
            {
                VeryActualizarCliente b = new VeryActualizarCliente();
                b.MdiParent = this;
                b.Show();
                SegActualizarClient = 1;
            }
        }

        private void iNGRESARSUPERIORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SegIngresarSuperior == 0)
            {
                IngresarMediSuperiores c = new IngresarMediSuperiores();
                c.MdiParent = this;
                c.Show();
                SegIngresarSuperior = 1;
            }
        }

        private void iNGRESARINFERIORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SegIngresarInfer == 0)
            {
                IngresarMediInferiores d = new IngresarMediInferiores();
                d.MdiParent = this;
                d.Show();
                SegIngresarInfer = 1;
            }
        }

        private void aCTUALIZARSUPERIORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SegActualizarSUP == 0)
            {
                ActualizarSuperiores z = new ActualizarSuperiores();
                z.MdiParent = this;
                z.Show();
                SegActualizarSUP = 1;
            }
        }

        private void aCTUALIZARINFERIORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (segActualizarINFER == 0)
            {
                ActualizarInferiores f = new ActualizarInferiores();
                f.MdiParent = this;
                f.Show();
                segActualizarINFER = 1;
            }
        }

        private void rEGISTRARPEDIDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SegRegistrarPedido == 0)
            {
                RegistrarPedido g = new RegistrarPedido();
                g.MdiParent = this;
                g.Show();
                SegRegistrarPedido = 1;
            }
        }

        private void vERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SegVerPedido == 0)
            {
                VerPedidos h = new VerPedidos();
                h.MdiParent = this;
                h.Show();
                SegVerPedido = 1;
            }
        }

        private void rEGISTRARVENTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SegRegistrarVent == 0)
            {
                RegistrarVenta j = new RegistrarVenta();
                j.MdiParent = this;
                j.Show();
                SegRegistrarVent = 1;

            }
        }

        private void vERVENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SegVerVenta == 0)
            {
                VerVentas k = new VerVentas();
                k.MdiParent = this;
                k.Show();
                SegVerVenta = 1;
            }
        }

        private void rEGISTRARSERVICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SegCrearServicio == 0)
            {
                CrearServicio l = new CrearServicio();
                l.MdiParent = this;
                l.Show();
                SegCrearServicio = 1;
            }
        }

        private void aCTUALIZARSERVICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SegActualizarServic == 0)
            {
                ActualizarServicio m = new ActualizarServicio();
                m.MdiParent = this;
                m.Show();
                SegActualizarServic = 1;
            }
        }

        private void aYUDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SegVerAyuda == 0)
            {
                Ayuda n = new Ayuda();
                n.MdiParent = this;
                n.Show();
                SegVerAyuda = 1;
            }
        }
    }
    
}
