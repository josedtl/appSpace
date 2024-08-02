namespace Space.Desk.Formulario.Empresa
{
    partial class EmpresaMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpresaMain));
            label1 = new Label();
            btnActualizar = new Button();
            BtnNuevo = new Button();
            DataListEmpresa = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DataListEmpresa).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.TopRight;
            label1.Location = new Point(13, 14);
            label1.Name = "label1";
            label1.Size = new Size(107, 26);
            label1.TabIndex = 9;
            label1.Text = "Empresa";
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnActualizar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizar.ForeColor = SystemColors.ButtonHighlight;
            btnActualizar.Image = (Image)resources.GetObject("btnActualizar.Image");
            btnActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizar.Location = new Point(1121, 14);
            btnActualizar.Margin = new Padding(4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(43, 40);
            btnActualizar.TabIndex = 16;
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // BtnNuevo
            // 
            BtnNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNuevo.Cursor = Cursors.Hand;
            BtnNuevo.FlatAppearance.BorderSize = 0;
            BtnNuevo.FlatAppearance.MouseDownBackColor = Color.Gray;
            BtnNuevo.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnNuevo.FlatStyle = FlatStyle.Flat;
            BtnNuevo.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnNuevo.ForeColor = SystemColors.ButtonHighlight;
            BtnNuevo.Image = (Image)resources.GetObject("BtnNuevo.Image");
            BtnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            BtnNuevo.Location = new Point(1172, 14);
            BtnNuevo.Margin = new Padding(4);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(41, 40);
            BtnNuevo.TabIndex = 15;
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // DataListEmpresa
            // 
            DataListEmpresa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataListEmpresa.BackgroundColor = Color.FromArgb(250, 250, 250);
            DataListEmpresa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataListEmpresa.Location = new Point(8, 73);
            DataListEmpresa.Name = "DataListEmpresa";
            DataListEmpresa.RowHeadersWidth = 51;
            DataListEmpresa.RowTemplate.Height = 24;
            DataListEmpresa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataListEmpresa.Size = new Size(1167, 539);
            DataListEmpresa.TabIndex = 18;
            DataListEmpresa.DoubleClick += DataListPersona_DoubleClick;
            // 
            // EmpresaMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(1213, 692);
            Controls.Add(DataListEmpresa);
            Controls.Add(BtnNuevo);
            Controls.Add(btnActualizar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmpresaMain";
            Text = "EmpresaMain";
            ((System.ComponentModel.ISupportInitialize)DataListEmpresa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.DataGridView DataListEmpresa;
    }
}