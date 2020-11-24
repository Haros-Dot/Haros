using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImplementacionMultiHilos
{

    public partial class Ventana2 : Form
    {
        public event Delegado ValueUpdate;
        public Ventana2()
        {
            InitializeComponent();
        }

        public void ModifyLabel(string entrada) {
            lbtextoresultado.Text = entrada;
        }

        private void Lb_TextoAqui_Click(object sender, EventArgs e)
        {

        }
    }
}
