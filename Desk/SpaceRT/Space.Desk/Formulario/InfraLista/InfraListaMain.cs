using Space.Desk.Formulario.Infraestructura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service = Space.ServiceConsumer.Service;

namespace Space.Desk.Formulario.InfraLista
{
    public partial class InfraListaMain : Form
    {
        string m_Codigocampo = string.Empty;
        public InfraListaMain(String CodigoCampo)
        {
            InitializeComponent();
            CargarTabla(CodigoCampo);
            m_Codigocampo = CodigoCampo;
        }

        public async void CargarTabla(String CodigoCampo)
        {
            try
            {

                var TituloItem = await Service.GeneralService.GetInfraCampoTitulo(CodigoCampo);
                lblTitulo.Text = TituloItem[0].Titulo;

                var Infra_Lista = await Service.GeneralService.GetInfraLista_Main(CodigoCampo);

                Int32 Cont = 0;
                foreach (var i in Infra_Lista) // TAMBIEN PUEDE SER UN "VAR"
                {
                    Cont = Cont + 1;
                    i.Item = Cont;
                }

                GridInfraLista.DataSource = null;
                GridInfraLista.DataSource = Infra_Lista;
                GridInfraLista.Columns["ListaId"].Visible = false;
                GridInfraLista.Columns["Item"].Width = 25;
                GridInfraLista.Columns["Item"].HeaderText = "Nº";
                GridInfraLista.Columns["CampoId"].Visible = false;
                GridInfraLista.Columns["Codigo"].Width = 80;
                GridInfraLista.Columns["Codigo"].HeaderText = "Codigo";
                GridInfraLista.Columns["Nombre"].Width = 180;
                GridInfraLista.Columns["Nombre"].HeaderText = "Nombre";
                GridInfraLista.Columns["Descripcion"].Width = 180;
                GridInfraLista.Columns["Descripcion"].HeaderText = "Descripción";
                GridInfraLista.Columns["FechaRegistro"].HeaderText = "Fecha Registro";
                GridInfraLista.Columns["FechaRegistro"].Width = 80;
                GridInfraLista.Columns["CodUsuario"].HeaderText = "Usuario";
                GridInfraLista.Columns["CodUsuario"].Width = 50;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en el proceso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private InfraListaSave ObjFrmFormaListaSave;



        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            if (ObjFrmFormaListaSave == null || ObjFrmFormaListaSave.IsDisposed)
            {
                this.ObjFrmFormaListaSave = new InfraListaSave(0, m_Codigocampo);
                ObjFrmFormaListaSave.ShowDialog();
            }
            else
            {
                ObjFrmFormaListaSave.Activate();
            }
        }

        private InfraListaSave ObjFrmForma;
        private async void GridInfraLista_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow row = GridInfraLista.CurrentRow;

            if (row != null)
            {
                // Obtener el valor de la primera celda de la fila seleccionada
                Int32 valor = Convert.ToInt32(row.Cells["ListaId"].Value);


                var Items = await Service.InfraListaService.GetInfraListaItem(valor);



                if (Items != null && Items.Count > 0)
                {
                    var Item_Select = Items[0];

                    //Infraestructura = Item_Select;


                    //EsAdd = false;



                    if (ObjFrmForma == null || ObjFrmForma.IsDisposed)
                    {
                        ObjFrmForma = new InfraListaSave(valor, m_Codigocampo);
                        ObjFrmForma.ShowDialog();
                        if (ObjFrmForma.Response_Pop)
                        {
                            ObjFrmForma.Response_Pop = false;
                            CargarTabla(m_Codigocampo);
                        }
                        ObjFrmForma = null;

                    }
                    else
                    {
                        ObjFrmForma.Activate();
                    }
                }

            }
        }
    }

}