namespace AppProyecto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtSueldo = new TextBox();
            label2 = new Label();
            txtTotalBruto = new TextBox();
            button1 = new Button();
            rbtnPlantilla = new RadioButton();
            rdtnHonorarios = new RadioButton();
            panel1 = new Panel();
            ckbFamiliar = new CheckBox();
            ckbPension = new CheckBox();
            ckbEssalud = new CheckBox();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(236, 83);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Sueldo:";
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(288, 80);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(100, 23);
            txtSueldo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 388);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 5;
            label2.Text = "Sueldo Total a Pagar:";
            // 
            // txtTotalBruto
            // 
            txtTotalBruto.Location = new Point(289, 385);
            txtTotalBruto.Name = "txtTotalBruto";
            txtTotalBruto.Size = new Size(100, 23);
            txtTotalBruto.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(463, 298);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // rbtnPlantilla
            // 
            rbtnPlantilla.AutoSize = true;
            rbtnPlantilla.Location = new Point(34, 31);
            rbtnPlantilla.Name = "rbtnPlantilla";
            rbtnPlantilla.Size = new Size(67, 19);
            rbtnPlantilla.TabIndex = 8;
            rbtnPlantilla.TabStop = true;
            rbtnPlantilla.Text = "Plantilla";
            rbtnPlantilla.UseVisualStyleBackColor = true;
            // 
            // rdtnHonorarios
            // 
            rdtnHonorarios.AutoSize = true;
            rdtnHonorarios.Location = new Point(166, 31);
            rdtnHonorarios.Name = "rdtnHonorarios";
            rdtnHonorarios.Size = new Size(84, 19);
            rdtnHonorarios.TabIndex = 9;
            rdtnHonorarios.TabStop = true;
            rdtnHonorarios.Text = "Honorarios";
            rdtnHonorarios.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(ckbFamiliar);
            panel1.Controls.Add(ckbPension);
            panel1.Controls.Add(ckbEssalud);
            panel1.Location = new Point(288, 230);
            panel1.Name = "panel1";
            panel1.Size = new Size(113, 91);
            panel1.TabIndex = 10;
            // 
            // ckbFamiliar
            // 
            ckbFamiliar.AutoSize = true;
            ckbFamiliar.Location = new Point(27, 66);
            ckbFamiliar.Name = "ckbFamiliar";
            ckbFamiliar.Size = new Size(78, 19);
            ckbFamiliar.TabIndex = 13;
            ckbFamiliar.Text = "P.Familiar";
            ckbFamiliar.UseVisualStyleBackColor = true;
            // 
            // ckbPension
            // 
            ckbPension.AutoSize = true;
            ckbPension.Location = new Point(27, 41);
            ckbPension.Name = "ckbPension";
            ckbPension.Size = new Size(68, 19);
            ckbPension.TabIndex = 12;
            ckbPension.Text = "Pension";
            ckbPension.UseVisualStyleBackColor = true;
            // 
            // ckbEssalud
            // 
            ckbEssalud.AutoSize = true;
            ckbEssalud.Location = new Point(27, 16);
            ckbEssalud.Name = "ckbEssalud";
            ckbEssalud.Size = new Size(65, 19);
            ckbEssalud.TabIndex = 11;
            ckbEssalud.Text = "Essalud";
            ckbEssalud.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnPlantilla);
            groupBox1.Controls.Add(rdtnHonorarios);
            groupBox1.Location = new Point(288, 134);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(264, 79);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1017, 614);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(txtTotalBruto);
            Controls.Add(label2);
            Controls.Add(txtSueldo);
            Controls.Add(label1);
            Name = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSueldo;
        private Label label2;
        private TextBox txtTotalBruto;
        private Button button1;
        private RadioButton rbtnPlantilla;
        private RadioButton rdtnHonorarios;
        private Panel panel1;
        private CheckBox ckbEssalud;
        private CheckBox ckbFamiliar;
        private CheckBox ckbPension;
        private GroupBox groupBox1;
    }
}