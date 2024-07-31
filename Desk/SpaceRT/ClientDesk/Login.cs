using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientDesk
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
          
                FMenu formPricipal = new FMenu();
                this.Hide();
                formPricipal.ShowDialog();
                this.Close();
          

        }
        private FMenu ObjFrmForma;

   
    }
}
