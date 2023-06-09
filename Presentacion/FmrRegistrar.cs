using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace Presentacion
{
    public partial class FmrRegistrar : Form
    {
        Servicios_Persona servicos_Persona = new Servicios_Persona();
        public FmrRegistrar()
        {
            InitializeComponent();
        }



        #region "Funcionalidades del from"
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void Cerrar()
        {
            this.Close();
            Salir();
        }
        private void Salir()
        {
            this.Owner.Show();
            Dispose();
        }
        #endregion

        #region "Funcionalidades de captura de datos"
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            Persona persona = new Persona(txbCedula.Text, txbNombre.Text, txbTelefono.Text);
            MessageBox.Show(servicos_Persona.AddPersona(persona));
        }

        private void CargarGrilla()
        {
            dgvPersonas.DataSource=ConsultarPersonas();
        }
        
        private List<Persona> ConsultarPersonas()
        {
            return servicos_Persona.GetPersonaList();
        }

        #endregion

        private void FmrRegistrar_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }



    }
}
