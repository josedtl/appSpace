using Space.Desk.Formulario.Infraestructura;
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

namespace Space.Desk.Formulario.Empresa
{
    public partial class EmpresaMain : Form
    {
        Boolean EsAdd = true;
        PersonaNaturalSaveModel Persona = new PersonaNaturalSaveModel();    
        public EmpresaMain()
        {
            InitializeComponent();
            CargaTable();
            EsAdd = true;

        }

        private async void CargaTable()
        {
            var Items = await Service.PersonaNaturalService.GetPersonaNaturalMain();

            Int32 Cont = 0;
            foreach (PersonaNaturalMainModel i in Items) // TAMBIEN PUEDE SER UN "VAR"
            {
                Cont = Cont + 1;
                i.Item = Cont;
            }
            DataListEmpresa.DataSource = null;
            DataListEmpresa.DataSource = Items;

            DataListEmpresa.Columns["PersonaNaturaId"].Visible = false;
            DataListEmpresa.Columns["Item"].HeaderText = "Nº";
            DataListEmpresa.Columns["Item"].Width = 25;
            DataListEmpresa.Columns["TipoDocumento"].HeaderText = "Documento";
            DataListEmpresa.Columns["TipoDocumento"].Width = 70;
            DataListEmpresa.Columns["RazonSocial"].HeaderText = "Nombre";
            DataListEmpresa.Columns["RazonSocial"].Width = 150;
            DataListEmpresa.Columns["PagWeb"].HeaderText = "Apellido Paterno";
            DataListEmpresa.Columns["PagWeb"].Width = 120;
            DataListEmpresa.Columns["Correo"].HeaderText = "Apellido Materno";
            DataListEmpresa.Columns["Correo"].Width = 120;
            DataListEmpresa.Columns["Telefono"].HeaderText = "Apellido Paterno";
            DataListEmpresa.Columns["Telefono"].Width = 120;
            DataListEmpresa.Columns["Direccion"].HeaderText = "Apellido Materno";
            DataListEmpresa.Columns["Direccion"].Width = 120;
            DataListEmpresa.Columns["UbigeoId"].HeaderText = "Fecha Registro";
            DataListEmpresa.Columns["UbigeoId"].Width = 120;
            DataListEmpresa.Columns["FechaRegistro"].HeaderText = "Fecha Registro";
            DataListEmpresa.Columns["FechaRegistro"].Width = 120;
            DataListEmpresa.Columns["CodUsuario"].HeaderText = "Usuario";
            DataListEmpresa.Columns["CodUsuario"].Width = 50;

        }

        private EmpresaPopup ObjFrmFormaPersona;

        private async void DataListPersona_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow row = DataListEmpresa.CurrentRow;
            if (row != null)
            {
                // Obtener el valor de la primera celda de la fila seleccionada
                Int32 valor = Convert.ToInt32(row.Cells["PersonaNaturaId"].Value);

                var Items = await Service.PersonaNaturalService.GetPersonaNaturalItem(valor);

                if (Items != null && Items.Count > 0)
                {
                    var Item_Select = Items[0];

                    Persona = Item_Select;

                    EsAdd = false;

                    if (ObjFrmFormaPersona == null || ObjFrmFormaPersona.IsDisposed)
                    {
                        ObjFrmFormaPersona = new EmpresaPopup(valor);
                        ObjFrmFormaPersona.ShowDialog();
                        if (ObjFrmFormaPersona.Response_Persona)
                        {
                            ObjFrmFormaPersona.Response_Persona = false;
                            CargaTable();
                        }
                        ObjFrmFormaPersona = null;

                    }
                    else
                    {
                        ObjFrmFormaPersona.Activate();
                    }
                }

            }

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            if(ObjFrmFormaPersona == null || ObjFrmFormaPersona.IsDisposed)
            {
                ObjFrmFormaPersona = new EmpresaPopup(0);
                ObjFrmFormaPersona.ShowDialog();
                ObjFrmFormaPersona=null;
            }
            else
            {
                ObjFrmFormaPersona.Activate();
            }
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {

                CargaTable();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al compilar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            

        }
    }
}
