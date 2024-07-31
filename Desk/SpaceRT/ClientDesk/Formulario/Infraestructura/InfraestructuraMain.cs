using ClientDesk.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientDesk.Formulario.Infraestructura
{
    public partial class InfraestructuraMain : Form
    {
        Boolean EsAdd = true;
        InfraestructuraSaveModel Infraestructura = new InfraestructuraSaveModel();
        public InfraestructuraMain()
        {
            InitializeComponent();
            CargarTable();

            EsAdd = true;

        }
        public async void CargarTable()
        {


            try
            {
                var Infrastructura_Lista = await Service.InfraestructuraService.GetInfraestructuraMain();

                Int32 Cont = 0;
                foreach (var i in Infrastructura_Lista) // TAMBIEN PUEDE SER UN "VAR"
                {
                    Cont = Cont + 1;
                    i.Item = Cont;
                }

                GridListInfraestructura.DataSource = null;
                GridListInfraestructura.DataSource = Infrastructura_Lista;
                GridListInfraestructura.Columns["InfraestructuraId"].Visible = false;
                GridListInfraestructura.Columns["Item"].Width = 25;
                GridListInfraestructura.Columns["Item"].HeaderText = "Nº";
                GridListInfraestructura.Columns["Sucursal"].Width = 150;
                GridListInfraestructura.Columns["Sucursal"].HeaderText = "Sucursal";
                GridListInfraestructura.Columns["CodigoSistema"].Width = 50;
                GridListInfraestructura.Columns["CodigoSistema"].HeaderText = "Codigo Sistema";
                GridListInfraestructura.Columns["CodigoInterno"].Width = 50;
                GridListInfraestructura.Columns["CodigoInterno"].HeaderText = "Codigo Interno";
                GridListInfraestructura.Columns["Descripcion"].MinimumWidth = 150;
                GridListInfraestructura.Columns["Descripcion"].Width = 150;
                GridListInfraestructura.Columns["Descripcion"].HeaderText = "Descripción";
                GridListInfraestructura.Columns["TipoInfraestructura"].Width = 150;
                GridListInfraestructura.Columns["TipoInfraestructura"].HeaderText = "Tipo Infraestructura";
                GridListInfraestructura.Columns["InfraestructuraDimension"].Width = 80;
                GridListInfraestructura.Columns["InfraestructuraDimension"].HeaderText = "Infraestructura Dimension";
                GridListInfraestructura.Columns["Aforo"].Width = 40;
                GridListInfraestructura.Columns["Aforo"].HeaderText = "Aforo";
                GridListInfraestructura.Columns["Piso"].Width = 60;
                GridListInfraestructura.Columns["Piso"].HeaderText = "Piso";
                GridListInfraestructura.Columns["FechaRegistro"].HeaderText = "Fecha Registro";
                GridListInfraestructura.Columns["FechaRegistro"].Width = 70;
                GridListInfraestructura.Columns["CodUsuario"].HeaderText = "Usuario";
                GridListInfraestructura.Columns["CodUsuario"].Width = 50;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en el proceso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }


        //private async void GridListInfraestructura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    DataGridViewRow row = GridListInfraestructura.CurrentRow;

        //    if (row != null)
        //    {
        //        // Obtener el valor de la primera celda de la fila seleccionada
        //        Int32 valor = Convert.ToInt32(row.Cells["InfraestructuraId"].Value);


        //        var Items = await Service.InfraestructuraService.GetInfraestructuraItem(valor);



        //        if (Items != null && Items.Count > 0)
        //        {
        //            var Item_Select = Items[0];

        //            Infraestructura = Item_Select;


        //            EsAdd = false;



        //            if (ObjFrmForma == null || ObjFrmForma.IsDisposed)
        //            {
        //                this.ObjFrmForma = new InfraestructuraPopup(valor);
        //                ObjFrmForma.Show();
        //            }
        //            else
        //            {
        //                ObjFrmForma.Activate();
        //            }
        //        }

        //    }
        //}

        private async void btn_Actualizar_Click(object sender, EventArgs e)
        {

        }

        private InfraestructuraPopup ObjFrmForma;

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {

        }

        private async void GridListInfraestructura_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow row = GridListInfraestructura.CurrentRow;

            if (row != null)
            {
                // Obtener el valor de la primera celda de la fila seleccionada
                Int32 valor = Convert.ToInt32(row.Cells["InfraestructuraId"].Value);

                var Items = await Service.InfraestructuraService.GetInfraestructuraItem(valor);

                if (Items != null && Items.Count > 0)
                {
                    var Item_Select = Items[0];

                    Infraestructura = Item_Select;

                    EsAdd = false;

                    if (ObjFrmForma == null || ObjFrmForma.IsDisposed)
                    {
                        ObjFrmForma = new InfraestructuraPopup(valor);
                        ObjFrmForma.ShowDialog();
                        if (ObjFrmForma.Response_Pop)
                        {
                            ObjFrmForma.Response_Pop = false;
                            CargarTable();
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

        private void InfraestructuraMain_Load(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            if (ObjFrmForma == null || ObjFrmForma.IsDisposed)
            {
                this.ObjFrmForma = new InfraestructuraPopup(0);
                //ObjFrmForma.Show();
                ObjFrmForma.ShowDialog();
                ObjFrmForma = null;

            }
            else
            {
                ObjFrmForma.Activate();
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
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
