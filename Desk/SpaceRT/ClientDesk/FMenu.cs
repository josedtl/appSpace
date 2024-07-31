using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientDesk
{
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {

            MenuVertical.Width = MenuVertical.Width == 250 ? 40 : 250;
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            pCatalogo.Visible = !pCatalogo.Visible;
        }

        private void btnInfraestructura_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Formulario.Infraestructura.InfraestructuraMain());
        }

        private void btnPiso_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Formulario.InfraLista.InfraListaMain("0009"));
        }

        private void btnPersonaNatural_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Formulario.Persona.PersonaMain());
        }

        private void btnTipoInfraestructura_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Formulario.InfraLista.InfraListaMain("0006"));
        }

        private void btnServicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Formulario.Servicio.ServicioMain());
        }
    }
}
