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

namespace Space.Desk.Formulario.Persona
{
    public partial class PersonaPopup : Form
    {
    Boolean EsAdd = true;
    PersonaNaturalSaveModel Persona = new PersonaNaturalSaveModel();

    public Boolean Response_Persona { get; set; }
        public PersonaPopup(Int32 Id)
        {
            InitializeComponent();
            Response_Persona=false;
            Cargado(Id);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public async void Cargado(Int32 Id)
        {
            try
            {
                cbo_EstadoCivil.ValueMember = "ListaId";
                cbo_EstadoCivil.DisplayMember = "Nombre";
                cbo_EstadoCivil.DataSource = await Service.GeneralService.GetListaRelacion("C0009");

                cbo_Sexo.ValueMember = "ListaId";
                cbo_Sexo.DisplayMember = "Nombre";
                cbo_Sexo.DataSource = await Service.GeneralService.GetListaRelacion("C0008");
                cbo_Documento.ValueMember = "ListaId";
                cbo_Documento.DisplayMember = "Nombre";

                List<ListaRelacionModel> ItemDocumentos = await Service.GeneralService.GetListaRelacion("C0012");

                ListaRelacionModel InsertDocumento_Seleccionar = new ListaRelacionModel();

                InsertDocumento_Seleccionar.ListaId = 0;
                InsertDocumento_Seleccionar.Nombre = "---SELECCIONE---";
                ItemDocumentos.Insert(0, InsertDocumento_Seleccionar);

                cbo_Documento.DataSource = ItemDocumentos;
                //dpFechaNacimiento.Format = DateTimePickerFormat.Custom;
                //dpFechaNacimiento.CustomFormat = "dd/MM/yyyy";


                //var Items = await Service.PersonaNaturalService.GetPersonaNaturalMain();

                //Int32 Cont = 0;
                //foreach (PersonaNaturalMainModel i in Items) // TAMBIEN PUEDE SER UN "VAR"
                //{
                //    Cont = Cont + 1;
                //    i.Item = Cont;
                //}

                if (Id > 0)
                {
                    EsAdd = false;
                    var Items = await Service.PersonaNaturalService.GetPersonaNaturalItem(Id);

                    if (Items != null && Items.Count > 0)
                    {
                        var Item_Select = Items[0];

                        Persona = Item_Select;
                        cbo_Documento.SelectedValue = Item_Select.TipoDocumentoIdentidadId;
                        txtNumDocumento.Text = Item_Select.NumDocumento;
                        txtNombre.Text = Item_Select.Nombres;
                        txtApellidoPaterno.Text = Item_Select.ApellidoPaterno;
                        txtApellidoMaterno.Text = Item_Select.ApellidoMaterno;
                        txtTelefono.Text = Item_Select.Telefono;
                        txtUbigeo.Text = Item_Select.UbigeoId.ToString();
                        dpFechaNacimiento.Text = Item_Select.FechaNacimiento.ToString();
                        cbo_EstadoCivil.SelectedValue = Item_Select.EstadoCivilId;
                        cbo_Sexo.SelectedValue = Item_Select.SexoId;
                        txtDireccion.Text = Item_Select.Direccion;
                        txtCorreo.Text = Item_Select.Correo;
                        Persona = Item_Select;

                        //btn_Agregar.Text = "Editar";
                        //EsAdd = false;
                    }

                }

                //GridListPersonas.DataSource = null;
                //GridListPersonas.DataSource = Items;

                //GridListPersonas.Columns["PersonaNaturaId"].Visible = false;
                //GridListPersonas.Columns["Item"].HeaderText = "Nº";
                //GridListPersonas.Columns["Item"].Width = 25;
                //GridListPersonas.Columns["TipoDocumento"].HeaderText = "Documento";
                //GridListPersonas.Columns["TipoDocumento"].Width = 70;
                //GridListPersonas.Columns["Nombres"].HeaderText = "Nombre";
                //GridListPersonas.Columns["Nombres"].Width = 150;
                //GridListPersonas.Columns["ApellidoPaterno"].HeaderText = "Apellido Paterno";
                //GridListPersonas.Columns["ApellidoPaterno"].Width = 120;
                //GridListPersonas.Columns["ApellidoMaterno"].HeaderText = "Apellido Materno";
                //GridListPersonas.Columns["ApellidoMaterno"].Width = 120;
                //GridListPersonas.Columns["FechaRegistro"].HeaderText = "Fecha Registro";
                //GridListPersonas.Columns["FechaRegistro"].Width = 120;
                //GridListPersonas.Columns["CodUsuario"].HeaderText = "Usuario";
                //GridListPersonas.Columns["CodUsuario"].Width = 50;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hobo un error en el proceso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                if ((Int32)cbo_Documento.SelectedValue == 0)
                {
                    MessageBox.Show("Seleccione un Tipo Documento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (String.IsNullOrEmpty(txtNumDocumento.Text.Trim()))
                {

                    MessageBox.Show("Debe llenar el campo Numero de Documento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (String.IsNullOrEmpty(txtNombre.Text.Trim()))
                {
                    MessageBox.Show("Debe llenar el campo Nombre", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (String.IsNullOrEmpty(txtApellidoPaterno.Text.Trim()))
                {
                    MessageBox.Show("Debe llenar el campo Apellido Paterno", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (String.IsNullOrEmpty(txtApellidoMaterno.Text.Trim()))
                {
                    MessageBox.Show("Debe llenar el campo Apellido Materno", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (String.IsNullOrEmpty(txtDireccion.Text.Trim()))
                {
                    MessageBox.Show("Debe llenar el campo Dirección", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (String.IsNullOrEmpty(txtTelefono.Text.Trim()))
                {
                    MessageBox.Show("Debe llenar el campo Telefono", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (String.IsNullOrEmpty(txtCorreo.Text.Trim()))
                {
                    MessageBox.Show("Debe llenar el campo Correo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if ((Int32)cbo_Sexo.SelectedValue == 0)
                {
                    MessageBox.Show("Seleccione un Tipo Documento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if ((Int32)cbo_EstadoCivil.SelectedValue == 0)
                {
                    MessageBox.Show("Seleccione un Tipo Documento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Persona.TipoDocumentoIdentidadId = (Int32)cbo_Documento.SelectedValue;
                Persona.NumDocumento = txtNumDocumento.Text;
                Persona.Nombres = txtNombre.Text;
                Persona.ApellidoPaterno = txtApellidoPaterno.Text;
                Persona.ApellidoMaterno = txtApellidoMaterno.Text;
                Persona.Direccion = txtDireccion.Text;
                Persona.Telefono = txtTelefono.Text;
                Persona.Correo = txtCorreo.Text;
                Persona.FechaNacimiento = DateTime.Now;
                Persona.FechaRegistro = DateTime.Now;
                Persona.SexoId = (Int32)cbo_Sexo.SelectedValue;
                Persona.EstadoCivilId = (Int32)cbo_EstadoCivil.SelectedValue;
                Persona.UbigeoId = 11;
                Persona.CodUsuario = "adm";


                if (EsAdd)
                {
                    var dato = Service.PersonaNaturalService.Save(Persona);
                    MessageBox.Show("Se guardo correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Response_Persona = true;
                    this.Close();
                }
                else
                {
                    var dato = Service.PersonaNaturalService.Update(Persona);
                    MessageBox.Show("Se guardo correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Response_Persona = true;
                    this.Close();
                }

                //CargaTable();
                MessageBox.Show("Se guardo correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al compilar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void Limpiar()
        {

            cbo_Documento.SelectedValue = -1;
            txtNumDocumento.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtApellidoPaterno.Text = String.Empty;
            txtApellidoMaterno.Text = String.Empty;
            txtDireccion.Text = String.Empty;
            txtCorreo.Text = String.Empty;
            cbo_Sexo.SelectedValue = -1;
            cbo_EstadoCivil.SelectedValue = -1;
            dpFechaNacimiento.Value = DateTime.Now;
            txtTelefono.Text = String.Empty;
            Persona = null;
            Persona = new PersonaNaturalSaveModel();
            btnAceptar.Text = "Editar";
            EsAdd = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
