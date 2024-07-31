using ClientDesk.Formulario.Infraestructura;
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

namespace ClientDesk.Formulario.Persona
{
    public partial class PersonaMain : Form
    {
        Boolean EsAdd = true;
        PersonaNaturalSaveModel Persona = new PersonaNaturalSaveModel();    
        public PersonaMain()
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
            DataListPersona.DataSource = null;
            DataListPersona.DataSource = Items;

            DataListPersona.Columns["PersonaNaturaId"].Visible = false;
            DataListPersona.Columns["Item"].HeaderText = "Nº";
            DataListPersona.Columns["Item"].Width = 25;
            DataListPersona.Columns["TipoDocumento"].HeaderText = "Documento";
            DataListPersona.Columns["TipoDocumento"].Width = 70;
            DataListPersona.Columns["Nombres"].HeaderText = "Nombre";
            DataListPersona.Columns["Nombres"].Width = 150;
            DataListPersona.Columns["ApellidoPaterno"].HeaderText = "Apellido Paterno";
            DataListPersona.Columns["ApellidoPaterno"].Width = 120;
            DataListPersona.Columns["ApellidoMaterno"].HeaderText = "Apellido Materno";
            DataListPersona.Columns["ApellidoMaterno"].Width = 120;
            DataListPersona.Columns["FechaRegistro"].HeaderText = "Fecha Registro";
            DataListPersona.Columns["FechaRegistro"].Width = 120;
            DataListPersona.Columns["CodUsuario"].HeaderText = "Usuario";
            DataListPersona.Columns["CodUsuario"].Width = 50;

        }

        private PersonaPopup ObjFrmFormaPersona;

        private async void DataListPersona_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow row = DataListPersona.CurrentRow;
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
                        ObjFrmFormaPersona = new PersonaPopup(valor);
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
                ObjFrmFormaPersona = new PersonaPopup(0);
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
