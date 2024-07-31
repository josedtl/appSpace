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

namespace Space.Desk.Formulario.InfraLista
{
    public partial class InfraListaSave : Form
    {

        Boolean EsAdd = true;
        InfraListaSaveModel InfraLista = new InfraListaSaveModel();


        string m_Codigocampo = String.Empty;

        public Boolean Response_Pop { get; set; }

        public InfraListaSave(Int32 Id, string Codigocampo)
        {
            InitializeComponent();
            Response_Pop = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            Cargado(Id);
            m_Codigocampo = Codigocampo;
        }

        public async void Cargado(Int32 Id)
        {

            EsAdd = true;
            if (Id > 0)
            {


                EsAdd = false;
                var Items = await Service.InfraListaService.GetInfraListaItem(Id);

                if (Items != null && Items.Count > 0)
                {
                    var Item_Select = Items[0];

                    InfraLista = Item_Select;
                    txtCodigo.Text = Item_Select.Codigo;
                    txtDescripcion.Text = Item_Select.Descripcion;
                    txtNombre.Text = Item_Select.Nombre;
                    chkEstadoRegistro.Checked = Item_Select.EstadoRegistro;
                    //btn_Agregar.Text = "Editar";
                    //EsAdd = false;
                }

            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtCodigo.Text.Trim()))
                {
                    MessageBox.Show("Debe llenar el campo Codigo ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (String.IsNullOrEmpty(txtNombre.Text.Trim()))
                {
                    MessageBox.Show("Debe llenar el campo Nombre", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (String.IsNullOrEmpty(txtDescripcion.Text.Trim()))
                {
                    MessageBox.Show("Debe llenar el Descripcion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                InfraLista.Codigocampo = m_Codigocampo;
                InfraLista.Codigo = txtCodigo.Text;
                InfraLista.Nombre = txtNombre.Text;
                InfraLista.Descripcion = txtDescripcion.Text;
                InfraLista.FechaRegistro = DateTime.Now;
                InfraLista.CodUsuario = AccesoStatic.User;
                InfraLista.EstadoRegistro = chkEstadoRegistro.Checked;

                if (EsAdd)
                {
                    var dato = await Service.GeneralService.Save(InfraLista);
                    Response_Pop = true;
                    this.Close();
                }
                else
                {
                    var dato = await Service.GeneralService.Update(InfraLista);
                    Response_Pop = true;
                    this.Close();
                }


                Limpiar();
                MessageBox.Show("Se guardo correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al compilar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Limpiar()
        {

            txtCodigo.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtDescripcion.Text = String.Empty;
            EsAdd = true;
            btnAgregar.Text = "Agregar";

        }
    }
}
