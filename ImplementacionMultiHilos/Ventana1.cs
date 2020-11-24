using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ImplementacionMultiHilos
{
    public partial class Ventana1 : Form
    {
        Ventana2 Prueba = new Ventana2();
        Thread BProgreso;

        public Ventana1()
        {
            InitializeComponent();
        }

        public void BarraProgreso() {
            Invoke(new MethodInvoker(() => { Prueba.Hide(); }));
            Invoke(new MethodInvoker(() => { barracarga.Value = 0; }));
            for (int i = 0; i < 1000; i++) {
                if (barracarga.Value == barracarga.Maximum)
                {
                    Invoke(new MethodInvoker(() => { Prueba.Show(); }));
                    break;
                }
                else {
                    Invoke(new MethodInvoker(()=> { barracarga.Value += 1; }));
                    Thread.Sleep(100);
                }
            }
        }

        private void Btn_AbrirForm_Click(object sender, EventArgs e)
        {
            BProgreso = new Thread(BarraProgreso);
            BProgreso.Start();
        }

        private void Btn_PasarTexto_Click(object sender, EventArgs e)
        {
            Prueba.ModifyLabel(textBoxpantalla.Text);
        }
    }
}
