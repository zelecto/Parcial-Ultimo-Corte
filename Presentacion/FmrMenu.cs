using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FmrMenu : Form
    {
        public FmrMenu()
        {
            InitializeComponent();
        }

        private void btnReguistrar_Click(object sender, EventArgs e)
        {
            AbrirRegistro(new FmrRegistrar());
        }
        private void AbrirRegistro(FmrRegistrar f)
        {
            this.Hide();
            f.ShowDialog(this);
        }
    }
}
