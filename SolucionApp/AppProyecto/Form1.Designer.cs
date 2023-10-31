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
            rbtnHonorarios = new RadioButton();
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
            label1.Location = new Point(270, 111);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Sueldo:";
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(329, 107);
            txtSueldo.Margin = new Padding(3, 4, 3, 4);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(114, 27);
            txtSueldo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 517);
            label2.Name = "label2";
            label2.Size = new Size(148, 20);
            label2.TabIndex = 5;
            label2.Text = "Sueldo Total a Pagar:";
            // 
            // txtTotalBruto
            // 
            txtTotalBruto.Location = new Point(330, 513);
            txtTotalBruto.Margin = new Padding(3, 4, 3, 4);
            txtTotalBruto.Name = "txtTotalBruto";
            txtTotalBruto.Size = new Size(114, 27);
            txtTotalBruto.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(529, 397);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 7;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // rbtnPlantilla
            // 
            rbtnPlantilla.AutoSize = true;
            rbtnPlantilla.Location = new Point(39, 41);
            rbtnPlantilla.Margin = new Padding(3, 4, 3, 4);
            rbtnPlantilla.Name = "rbtnPlantilla";
            rbtnPlantilla.Size = new Size(83, 24);
            rbtnPlantilla.TabIndex = 8;
            rbtnPlantilla.TabStop = true;
            rbtnPlantilla.Text = "Plantilla";
            rbtnPlantilla.UseVisualStyleBackColor = true;
            // 
            // rbtnHonorarios
            // 
            rbtnHonorarios.AutoSize = true;
            rbtnHonorarios.Location = new Point(190, 41);
            rbtnHonorarios.Margin = new Padding(3, 4, 3, 4);
            rbtnHonorarios.Name = "rbtnHonorarios";
            rbtnHonorarios.Size = new Size(104, 24);
            rbtnHonorarios.TabIndex = 9;
            rbtnHonorarios.TabStop = true;
            rbtnHonorarios.Text = "Honorarios";
            rbtnHonorarios.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(ckbFamiliar);
            panel1.Controls.Add(ckbPension);
            panel1.Controls.Add(ckbEssalud);
            panel1.Location = new Point(329, 307);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(129, 121);
            panel1.TabIndex = 10;
            // 
            // ckbFamiliar
            // 
            ckbFamiliar.AutoSize = true;
            ckbFamiliar.Location = new Point(31, 88);
            ckbFamiliar.Margin = new Padding(3, 4, 3, 4);
            ckbFamiliar.Name = "ckbFamiliar";
            ckbFamiliar.Size = new Size(94, 24);
            ckbFamiliar.TabIndex = 13;
            ckbFamiliar.Text = "P.Familiar";
            ckbFamiliar.UseVisualStyleBackColor = true;
            // 
            // ckbPension
            // 
            ckbPension.AutoSize = true;
            ckbPension.Location = new Point(31, 55);
            ckbPension.Margin = new Padding(3, 4, 3, 4);
            ckbPension.Name = "ckbPension";
            ckbPension.Size = new Size(81, 24);
            ckbPension.TabIndex = 12;
            ckbPension.Text = "Pension";
            ckbPension.UseVisualStyleBackColor = true;
            // 
            // ckbEssalud
            // 
            ckbEssalud.AutoSize = true;
            ckbEssalud.Location = new Point(31, 21);
            ckbEssalud.Margin = new Padding(3, 4, 3, 4);
            ckbEssalud.Name = "ckbEssalud";
            ckbEssalud.Size = new Size(80, 24);
            ckbEssalud.TabIndex = 11;
            ckbEssalud.Text = "Essalud";
            ckbEssalud.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnPlantilla);
            groupBox1.Controls.Add(rbtnHonorarios);
            groupBox1.Location = new Point(329, 179);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(302, 105);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(901, 666);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(txtTotalBruto);
            Controls.Add(label2);
            Controls.Add(txtSueldo);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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
        private RadioButton rbtnHonorarios;
        private Panel panel1;
        private CheckBox ckbEssalud;
        private CheckBox ckbFamiliar;
        private CheckBox ckbPension;
        private GroupBox groupBox1;
    }
}