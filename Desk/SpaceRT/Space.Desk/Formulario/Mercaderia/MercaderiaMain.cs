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

namespace Space.Desk.Formulario.Mercaderia
{
    public partial class MercaderiaMain : Form
    {
        public MercaderiaMain()
        {
            InitializeComponent();
            CargarTable();

        }

        public async void CargarTable()
        {
            try
            {
                var Mercaderia_Lista = await Service.MercaderiaService.GetMercaderiaMain();

                Int32 Cont = 0;
                foreach (var i in Mercaderia_Lista) // TAMBIEN PUEDE SER UN "VAR"
                {
                    Cont = Cont + 1;
                    i.Item = Cont;
                }

                GridListMercaderia.DataSource = null;
                GridListMercaderia.DataSource = Mercaderia_Lista;
                //GridListMercaderia.Columns["MercaderiaId"].Visible = false;
                //GridListMercaderia.Columns["Item"].Width = 25;
                //GridListMercaderia.Columns["Item"].HeaderText = "Nº";
                //GridListMercaderia.Columns["Sucursal"].Width = 150;
                //GridListMercaderia.Columns["Sucursal"].HeaderText = "Sucursal";
                //GridListMercaderia.Columns["CodigoSistema"].Width = 50;
                //GridListMercaderia.Columns["CodigoSistema"].HeaderText = "Codigo Sistema";
                //GridListMercaderia.Columns["CodigoInterno"].Width = 50;
                //GridListMercaderia.Columns["CodigoInterno"].HeaderText = "Codigo Interno";
                //GridListMercaderia.Columns["Descripcion"].MinimumWidth = 150;
                //GridListMercaderia.Columns["Descripcion"].Width = 150;
                //GridListMercaderia.Columns["Descripcion"].HeaderText = "Descripción";
                //GridListMercaderia.Columns["TipoInfraestructura"].Width = 150;
                //GridListMercaderia.Columns["TipoInfraestructura"].HeaderText = "Tipo Infraestructura";
                //GridListMercaderia.Columns["InfraestructuraDimension"].Width = 80;
                //GridListMercaderia.Columns["InfraestructuraDimension"].HeaderText = "Infraestructura Dimension";
                //GridListMercaderia.Columns["Aforo"].Width = 40;
                //GridListMercaderia.Columns["Aforo"].HeaderText = "Aforo";
                //GridListMercaderia.Columns["Piso"].Width = 60;
                //GridListMercaderia.Columns["Piso"].HeaderText = "Piso";
                //GridListMercaderia.Columns["FechaRegistro"].HeaderText = "Fecha Registro";
                //GridListMercaderia.Columns["FechaRegistro"].Width = 70;
                //GridListMercaderia.Columns["CodUsuario"].HeaderText = "Usuario";
                //GridListMercaderia.Columns["CodUsuario"].Width = 50;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en el proceso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }
}
