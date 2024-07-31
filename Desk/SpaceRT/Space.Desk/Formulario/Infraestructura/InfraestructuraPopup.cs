using Space.ServiceConsumer;
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

namespace Space.Desk.Formulario.Infraestructura
{
    public partial class InfraestructuraPopup : Form
    {
        //public static Boolean Response_Pop = false;
        Boolean EsAdd = true;
        InfraestructuraSaveModel Infraestructura = new InfraestructuraSaveModel();

        public Boolean Response_Pop { get; set; }

        public InfraestructuraPopup(Int32 Id)
        {
            InitializeComponent();

            Response_Pop = false;
            Cargado(Id);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public async void Cargado(Int32 Id)
        {
            cbo_Sucursal.ValueMember = "ListaId";
            cbo_Sucursal.DisplayMember = "Nombre";
            List<InfraListaModel> ItemSucursal = await Service.GeneralService.GetInFraLista_Codigo("0001");

            InfraListaModel InsertSucursal_Seleccionar = new InfraListaModel();

            InsertSucursal_Seleccionar.ListaId = 0;
            InsertSucursal_Seleccionar.Nombre = "---SELECCIONE---";
            ItemSucursal.Insert(0, InsertSucursal_Seleccionar);

            cbo_Sucursal.DataSource = ItemSucursal;

            cbo_TipoInfraestructura.ValueMember = "ListaId";
            cbo_TipoInfraestructura.DisplayMember = "Nombre";

            var ListaTipoInfraEstructuraCombo = await Service.GeneralService.GetInFraLista_Codigo("0006");

            ListaTipoInfraEstructuraCombo.Insert(0, new InfraListaModel { ListaId = 0, Nombre = "---SELECCIONE---" });

            cbo_TipoInfraestructura.DataSource = ListaTipoInfraEstructuraCombo;

            cbo_Dimension.ValueMember = "ListaId";
            cbo_Dimension.DisplayMember = "Nombre";
            cbo_Dimension.DataSource = await Service.GeneralService.GetInFraLista_Codigo("0007");

            cbo_Piso.ValueMember = "ListaId";
            cbo_Piso.DisplayMember = "Nombre";
            cbo_Piso.DataSource = await Service.GeneralService.GetInFraLista_Codigo("0009");

            if (Id > 0)
            {


                EsAdd = false;
                var Items = await Service.InfraestructuraService.GetInfraestructuraItem(Id);



                if (Items != null && Items.Count > 0)
                {
                    var Item_Select = Items[0];

                    Infraestructura = Item_Select;
                    cbo_Sucursal.SelectedValue = Item_Select.SucursalId;
                    txt_CodInterno.Text = Item_Select.CodigoInterno;
                    txt_CodSistema.Text = Item_Select.CodigoSistema;
                    cbo_TipoInfraestructura.SelectedValue = Item_Select.TipoInfraestructuraId;
                    cbo_Dimension.SelectedValue = Item_Select.InfraestructuraDimensionId;
                    txt_Aforo.Text = Item_Select.Aforo.ToString();
                    cbo_Piso.SelectedValue = Item_Select.PisoId;
                    txt_Descripcion.Text = Item_Select.Descripcion;
                    Infraestructura = Item_Select;

                    //btn_Agregar.Text = "Editar";
                    //EsAdd = false;
                }

            }
        }

        private async void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {

                if ((Int32)cbo_Sucursal.SelectedValue == 0)
                {
                    MessageBox.Show("Seleccione una Sucursal", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (String.IsNullOrEmpty(txt_CodInterno.Text.Trim()))
                {
                    MessageBox.Show("Debe llenar el campo Codigo Interno", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if ((Int32)cbo_TipoInfraestructura.SelectedValue == 0)
                {
                    MessageBox.Show("Seleccione un Tipo Infraestructura", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if ((Int32)cbo_Dimension.SelectedValue == 0)
                {
                    MessageBox.Show("Seleccione una Dimension", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (String.IsNullOrEmpty(txt_CodSistema.Text.Trim()))
                {
                    MessageBox.Show("Debe llenar el campo Codigo Sistema", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (String.IsNullOrEmpty(txt_Aforo.Text.Trim()))
                {
                    MessageBox.Show("Debe llenar el campo Aforo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if ((Int32)cbo_Piso.SelectedValue == 0)
                {
                    MessageBox.Show("Seleccione un Piso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (String.IsNullOrEmpty(txt_Descripcion.Text.Trim()))
                {
                    MessageBox.Show("Debe llenar el campo Descripcion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }

                Infraestructura.SucursalId = (Int32)cbo_Sucursal.SelectedValue;
                Infraestructura.CodigoInterno = txt_CodInterno.Text;
                Infraestructura.CodigoSistema = txt_CodSistema.Text;
                Infraestructura.TipoInfraestructuraId = (Int32)cbo_TipoInfraestructura.SelectedValue;
                Infraestructura.InfraestructuraDimensionId = (Int32)cbo_Dimension.SelectedValue;
                Infraestructura.Descripcion = txt_Descripcion.Text;
                Infraestructura.PisoId = (Int32)cbo_Piso.SelectedValue;
                Infraestructura.Aforo = Convert.ToInt32(txt_Aforo.Text);
                Infraestructura.FechaRegistro = DateTime.Now;
                Infraestructura.CodUsuario = "adm";
                Infraestructura.EstadoRegistro = true;
                if (EsAdd)
                {
                    var dato = await Service.InfraestructuraService.Save(Infraestructura);
                    MessageBox.Show("Se guardo correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Response_Pop = true;
                    this.Close();
                }
                else
                {
                    var dato = await Service.InfraestructuraService.Update(Infraestructura);
                    MessageBox.Show("Se guardo correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Response_Pop = true;
                    this.Close();
                }


                //Limpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al compilar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void Limpiar()
        {

            cbo_TipoInfraestructura.SelectedIndex = 0;
            cbo_Dimension.SelectedIndex = 0;
            cbo_Piso.SelectedIndex = 0;
            cbo_Sucursal.SelectedIndex = 0;
            txt_CodInterno.Text = String.Empty;
            txt_CodSistema.Text = String.Empty;
            txt_Descripcion.Text = String.Empty;
            txt_Aforo.Text = String.Empty;
            EsAdd = true;
            btn_Agregar.Text = "Agregar";

        }
    }
}
