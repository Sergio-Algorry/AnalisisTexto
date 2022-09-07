using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend;

namespace Frontend
{
    public partial class frm : Form
    {
        ProcesadorTexto pt = new ProcesadorTexto();
        int PrimerCaracter = -1;

        public frm()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            pt.TextoOriginal = txtOriginal.Text;
            pt.TextoBusqueda = txtBusqueda.Text;

            PrimerCaracter = pt.Buscar();

            if (PrimerCaracter == -1)
            {
                lblError.Text = "Busqueda no encontrada.";
            }
            else
            {
                lblError.Text = "Busqueda encontrada desde la posición: " + PrimerCaracter.ToString();
            }
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            pt.Borrar();
            txtResultado.Text = pt.TextoResultado;
            if (pt.TextoResultado == pt.TextoOriginal)
            {
                lblError.Text = "No se borró la busqueda";
            }
            else
            {
                lblError.Text = "Se borró la busqueda";
            }
        }
    }
}