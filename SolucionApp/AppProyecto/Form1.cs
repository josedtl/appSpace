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

        private void button1_Click(object sender, EventArgs e)
        {
            double Sueldo = double.Parse(this.txtSueldo.Text);
            Boolean m_Planilla = rbtnPlantilla.Checked;
            Boolean m_Honorario = rbtnHonorarios.Checked;
            Boolean m_essalud = ckbEssalud.Checked;
            Boolean m_pension = ckbPension.Checked;
            Boolean m_pFamiliar = ckbFamiliar.Checked;

            double essalud = Sueldo * 0.09;
            double pension = Sueldo * 0.11;
            double pFamiliar = Sueldo *0.03;
            double sueldoTotal = 0 ;

            double honorario = Sueldo * 0.07;

            if (m_Planilla)
            {
                if (ckbEssalud.Checked && ckbPension.Checked && ckbFamiliar.Checked)
                {
                    sueldoTotal = Sueldo +pFamiliar - essalud - pension;
                    txtTotalBruto.Text = "$" + sueldoTotal;
                }
                if (ckbEssalud.Checked && ckbPension.Checked)
                {
                    sueldoTotal = Sueldo - pension - essalud;
                    txtTotalBruto.Text = "$" + sueldoTotal;
                }
                if (ckbEssalud.Checked && ckbFamiliar.Checked)
                {
                    sueldoTotal = Sueldo + pFamiliar - essalud;
                    txtTotalBruto.Text = "$" + sueldoTotal;
                }
                if (ckbPension.Checked && ckbFamiliar.Checked)
                {
                    sueldoTotal = Sueldo + pFamiliar - pension;
                    txtTotalBruto.Text = "$" + sueldoTotal;
                }

                if (ckbEssalud.Checked)
                {
                    essalud = Sueldo - essalud;
                    txtTotalBruto.Text = "" + essalud;

                }if (ckbPension.Checked){
                    pension = Sueldo -pension;
                    txtTotalBruto.Text = "" + pension;
                }
                if (ckbFamiliar.Checked)
                {
                    pFamiliar = Sueldo + pFamiliar;
                    txtTotalBruto.Text = "" + pFamiliar;

                }

            }
            if (m_Honorario)
            {
                txtTotalBruto.Text = "" + Sueldo;
                if (Sueldo > 1500)
                {
                    sueldoTotal = Sueldo - honorario;
                    txtTotalBruto.Text = "" + sueldoTotal;
                }
            }
                
            
        }

        
    }
}