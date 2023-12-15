namespace AppProyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private Double Rest_Porcentaje(Double Cantidad, Double Porcentaje)
        {
            Double Resultado = (Cantidad + Porcentaje) / 100;
            return Resultado;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double Sueldo = double.Parse(this.txtSueldo.Text);
            Boolean m_Planilla = rbtnPlantilla.Checked;
            Boolean m_Honorario = rbtnHonorarios.Checked;


            Boolean Fla_EsSalud = ckbEssalud.Checked;
            Boolean Fla_Pension = ckbPension.Checked;
            Boolean Fla_Familiar = ckbFamiliar.Checked;


            double essalud = 0;
            double pension = 0;
            double pFamiliar = 0;
            double sueldoTotal = 0;
            double DescuentoHonorario = 0;



            if (m_Planilla == true)
            {

                if (Fla_EsSalud)
                {
                    essalud = Rest_Porcentaje(Sueldo, 9);

                }
                if (Fla_Familiar)
                {
                    pFamiliar = Rest_Porcentaje(Sueldo, 3);

                }
                if (Fla_Pension )
                {
                    pension = Rest_Porcentaje(Sueldo, 11);
                }
                sueldoTotal = (Sueldo - essalud - pension) + pFamiliar;

            }
            if (m_Honorario)
            {
                if (Sueldo > 1500)
                {
                    DescuentoHonorario = Rest_Porcentaje(Sueldo, 7);
                }
                sueldoTotal = Sueldo - DescuentoHonorario;
            }




            txtTotalBruto.Text = "" + sueldoTotal;


            //if (m_Planilla == true)
            //{
            //    if (ckbEssalud.Checked == true && ckbPension.Checked == true && ckbFamiliar.Checked == true)
            //    {
            //        sueldoTotal = Sueldo + pFamiliar - pension - essalud;
            //        txtTotalBruto.Text = "$ " + sueldoTotal;
            //    }
            //    else if (ckbEssalud.Checked == true && ckbPension.Checked == true)
            //    {
            //        sueldoTotal = Sueldo - pension - essalud;
            //        txtTotalBruto.Text = "$ " + sueldoTotal;
            //    }
            //    else if (ckbEssalud.Checked == true && ckbFamiliar.Checked == true)
            //    {
            //        sueldoTotal = Sueldo + pFamiliar - essalud;
            //        txtTotalBruto.Text = "$ " + sueldoTotal;
            //    }
            //    else if (ckbPension.Checked == true && ckbFamiliar.Checked == true)
            //    {
            //        sueldoTotal = Sueldo + pFamiliar - pension;
            //        txtTotalBruto.Text = "$ " + sueldoTotal;
            //    }

            //    else if (ckbEssalud.Checked == true)
            //    {
            //        sueldoTotal = Sueldo - essalud;
            //        txtTotalBruto.Text = "$ " + sueldoTotal;

            //    }
            //    else if (ckbPension.Checked == true)
            //    {
            //        sueldoTotal = Sueldo - pension;
            //        txtTotalBruto.Text = "$ " + sueldoTotal;
            //    }
            //    else
            //    {
            //        sueldoTotal = Sueldo + pFamiliar;
            //        txtTotalBruto.Text = "$ " + sueldoTotal;

            //    }
            //    //if (ckbFamiliar.Checked == true)
            //}
            //if (m_Honorario == true)
            //{
            //    txtTotalBruto.Text = "" + Sueldo;
            //    if (Sueldo > 1500)
            //    {
            //        sueldoTotal = Sueldo - honorario;
            //        txtTotalBruto.Text = "" + sueldoTotal;
            //    }
            //}


        }


    }
}