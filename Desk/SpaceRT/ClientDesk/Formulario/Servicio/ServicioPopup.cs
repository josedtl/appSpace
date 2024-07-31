using ClientDesk.Model;
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
    public partial class ServicioPopup : Form
    {
        Boolean EsAdd = true;
        ServicioSaveModel Servicio = new ServicioSaveModel();
        public Boolean Response_Pop { get; set; }

        public ServicioPopup(Int32 Id)
        {
            InitializeComponent();

            Response_Pop = false;
            Cargado(Id);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public async void Cargado(Int32 Id)
        {
            cbo_TipoServicio.ValueMember = "ListaId";
            cbo_TipoServicio.DisplayMember = "Nombre";
            List<ServListaModel> ItemTipoServ = await Service.ServListaService.GetServLista_Codigo("C004");

            ServListaModel InsertTipoServ_Seleccionar = new ServListaModel();

            InsertTipoServ_Seleccionar.ListaId = 0;
            InsertTipoServ_Seleccionar.Nombre = "---SELECCIONE---";
            ItemTipoServ.Insert(0, InsertTipoServ_Seleccionar);

            cbo_TipoServicio.DataSource = ItemTipoServ;

            if (Id > 0)
            {
                EsAdd = false;
                var Items = await Service.ServicioService.GetServicio_Item(Id);
                if (Items != null && Items.Count > 0)
                {
                    var Item_Select = Items[0];
                    Servicio = Item_Select;
                    txtNombre.Text = Item_Select.Nombre;
                    rtxtDescripcion.Text = Item_Select.Descripcion;
                    Servicio = Item_Select;
                }
            }
        }


        public void Limpiar()
        {
            txtNombre.Text = "";
            rtxtDescripcion.Text = "";
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtNombre.Text.Trim()))
                {
                    MessageBox.Show("Debe llenar el campo Nombre", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (String.IsNullOrEmpty(rtxtDescripcion.Text.Trim()))
                {
                    MessageBox.Show("Debe llenar el campo Descripcion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if ((Int32)cbo_TipoServicio.SelectedValue == 0)
                {
                    MessageBox.Show("Debe llenar el campo Descripcion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                Servicio.Nombre = txtNombre.Text;
                Servicio.Descripcion = rtxtDescripcion.Text;
                Servicio.TipoServicioId =(Int32)cbo_TipoServicio.SelectedValue;
                Servicio.FechaRegistro = DateTime.Now;
                Servicio.CodUsuario = "adm";
                Servicio.EstadoRegistro = true;

                if (EsAdd)
                {
                    var dato = await Service.ServicioService.Save(Servicio);
                    MessageBox.Show("Se guardo correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Response_Pop = true;
                    this.Close();
                }
                else
                {
                    var dato = await Service.ServicioService.Update(Servicio);
                    MessageBox.Show("Se guardo correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Response_Pop = true;
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al compilar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
