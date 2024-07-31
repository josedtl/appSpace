using ClientDesk.Model;
using ClientDesk.Formulario.Infraestructura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClientDesk.Formulario.Servicio
{
    public partial class ServicioMain : Form
    {
        Boolean EsAdd = true;
        ServicioSaveModel Servicio = new ServicioSaveModel();
        public ServicioMain()
        {
            InitializeComponent();
            CargarTable();

            EsAdd = true;
        }
        public async void CargarTable()
        {
            try
            {
                var Servicio_Lista = await Service.ServicioService.GetServicioMain();
                Int32 Cont = 0;
                foreach (var i in Servicio_Lista) // TAMBIEN PUEDE SER UN "VAR"
                {
                    Cont = Cont + 1;
                    i.Item = Cont;
                }
                dtServicio.DataSource = null;
                dtServicio.DataSource = Servicio_Lista;

                dtServicio.Columns["ServicioId"].Visible = false;
                dtServicio.Columns["Item"].Width = 25;
                dtServicio.Columns["Item"].HeaderText = "Nº";
                dtServicio.Columns["Correlativo"].Width = 50;
                dtServicio.Columns["Correlativo"].HeaderText = "Correlativo";
                dtServicio.Columns["Nombre"].Width = 50;
                dtServicio.Columns["Nombre"].HeaderText = "Nombre";
                dtServicio.Columns["Descripcion"].MinimumWidth = 150;
                dtServicio.Columns["Descripcion"].Width = 150;
                dtServicio.Columns["Descripcion"].HeaderText = "Descripción";
                dtServicio.Columns["TipoServicio"].Width = 150;
                dtServicio.Columns["TipoServicio"].HeaderText = "TipoServicio";
                dtServicio.Columns["FechaRegistro"].HeaderText = "Fecha Registro";
                dtServicio.Columns["FechaRegistro"].Width = 70;
                dtServicio.Columns["CodUsuario"].HeaderText = "Usuario";
                dtServicio.Columns["CodUsuario"].Width = 50;

            }
            catch (Exception ex)
            {

            }
        }

        private ServicioPopup ObjFrmServicio;

        private async void dtServicio_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow row = dtServicio.CurrentRow;

            if (row != null)
            {
                Int32 valor = Convert.ToInt32(row.Cells["ServicioId"].Value);

                var Items = await Service.ServicioService.GetServicio_Item(valor);

                if (Items != null && Items.Count > 0)
                {
                    var Item_Select = Items[0];

                    Servicio = Item_Select;

                    EsAdd = false;

                    if (ObjFrmServicio == null || ObjFrmServicio.IsDisposed)
                    {

                        ObjFrmServicio = new ServicioPopup(valor);

                        ObjFrmServicio.ShowDialog();

                        if (ObjFrmServicio.Response_Pop)
                        {
                            ObjFrmServicio.Response_Pop = false;
                            CargarTable();
                        }
                        ObjFrmServicio = null;

                    }
                    else
                    {
                        ObjFrmServicio.Activate();
                    }

                }

            }




        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            if (ObjFrmServicio == null || ObjFrmServicio.IsDisposed)
            {
                this.ObjFrmServicio = new ServicioPopup(0);
                //ObjFrmForma.Show();
                ObjFrmServicio.ShowDialog();
                ObjFrmServicio = null;

            }
            else
            {
                ObjFrmServicio.Activate();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al compilar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
