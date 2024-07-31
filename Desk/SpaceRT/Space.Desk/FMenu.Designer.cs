namespace Space.Desk
{
    partial class FMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenu));
            MenuVertical = new Panel();
            button7 = new Button();
            pCatalogo = new Panel();
            button1 = new Button();
            btnMercaderia = new Button();
            btnPersonaNatural = new Button();
            btnInfraestructura = new Button();
            btnPiso = new Button();
            button3 = new Button();
            button2 = new Button();
            btnTipoInfraestructura = new Button();
            btnCatalogo = new Button();
            btnMenu = new PictureBox();
            panel1 = new Panel();
            panelContenedor = new Panel();
            MenuVertical.SuspendLayout();
            pCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            SuspendLayout();
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(0, 21, 41);
            MenuVertical.Controls.Add(button7);
            MenuVertical.Controls.Add(pCatalogo);
            MenuVertical.Controls.Add(btnCatalogo);
            MenuVertical.Controls.Add(btnMenu);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Margin = new Padding(4, 3, 4, 3);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(292, 628);
            MenuVertical.TabIndex = 0;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseDownBackColor = Color.Gray;
            button7.FlatAppearance.MouseOverBackColor = Color.Silver;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(1, 88);
            button7.Margin = new Padding(4, 3, 4, 3);
            button7.Name = "button7";
            button7.RightToLeft = RightToLeft.No;
            button7.Size = new Size(292, 35);
            button7.TabIndex = 5;
            button7.Text = "          Orden de Trabajo";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = true;
            // 
            // pCatalogo
            // 
            pCatalogo.Controls.Add(button1);
            pCatalogo.Controls.Add(btnMercaderia);
            pCatalogo.Controls.Add(btnPersonaNatural);
            pCatalogo.Controls.Add(btnInfraestructura);
            pCatalogo.Controls.Add(btnPiso);
            pCatalogo.Controls.Add(button3);
            pCatalogo.Controls.Add(button2);
            pCatalogo.Controls.Add(btnTipoInfraestructura);
            pCatalogo.Location = new Point(4, 171);
            pCatalogo.Margin = new Padding(4, 3, 4, 3);
            pCatalogo.Name = "pCatalogo";
            pCatalogo.Size = new Size(288, 280);
            pCatalogo.TabIndex = 4;
            pCatalogo.Visible = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Gray;
            button1.FlatAppearance.MouseOverBackColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calibri Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-3, 148);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Padding = new Padding(41, 0, 0, 0);
            button1.Size = new Size(287, 23);
            button1.TabIndex = 8;
            button1.Text = "Servicio";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnMercaderia
            // 
            btnMercaderia.Anchor = AnchorStyles.Top;
            btnMercaderia.FlatAppearance.BorderSize = 0;
            btnMercaderia.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnMercaderia.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnMercaderia.FlatStyle = FlatStyle.Flat;
            btnMercaderia.Font = new Font("Calibri Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnMercaderia.ForeColor = SystemColors.ButtonHighlight;
            btnMercaderia.ImageAlign = ContentAlignment.MiddleLeft;
            btnMercaderia.Location = new Point(-3, 206);
            btnMercaderia.Margin = new Padding(4, 3, 4, 3);
            btnMercaderia.Name = "btnMercaderia";
            btnMercaderia.Padding = new Padding(41, 0, 0, 0);
            btnMercaderia.Size = new Size(287, 23);
            btnMercaderia.TabIndex = 7;
            btnMercaderia.Text = "Mercaderia";
            btnMercaderia.TextAlign = ContentAlignment.MiddleLeft;
            btnMercaderia.UseVisualStyleBackColor = true;
            btnMercaderia.Click += btnServicio_Click;
            // 
            // btnPersonaNatural
            // 
            btnPersonaNatural.Anchor = AnchorStyles.Top;
            btnPersonaNatural.FlatAppearance.BorderSize = 0;
            btnPersonaNatural.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnPersonaNatural.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnPersonaNatural.FlatStyle = FlatStyle.Flat;
            btnPersonaNatural.Font = new Font("Calibri Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPersonaNatural.ForeColor = SystemColors.ButtonHighlight;
            btnPersonaNatural.ImageAlign = ContentAlignment.MiddleLeft;
            btnPersonaNatural.Location = new Point(-7, 177);
            btnPersonaNatural.Margin = new Padding(4, 3, 4, 3);
            btnPersonaNatural.Name = "btnPersonaNatural";
            btnPersonaNatural.Padding = new Padding(41, 0, 0, 0);
            btnPersonaNatural.Size = new Size(287, 23);
            btnPersonaNatural.TabIndex = 6;
            btnPersonaNatural.Text = "Persona Natural";
            btnPersonaNatural.TextAlign = ContentAlignment.MiddleLeft;
            btnPersonaNatural.UseVisualStyleBackColor = true;
            btnPersonaNatural.Click += btnPersonaNatural_Click;
            // 
            // btnInfraestructura
            // 
            btnInfraestructura.Anchor = AnchorStyles.Top;
            btnInfraestructura.FlatAppearance.BorderSize = 0;
            btnInfraestructura.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnInfraestructura.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnInfraestructura.FlatStyle = FlatStyle.Flat;
            btnInfraestructura.Font = new Font("Calibri Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnInfraestructura.ForeColor = SystemColors.ButtonHighlight;
            btnInfraestructura.ImageAlign = ContentAlignment.MiddleLeft;
            btnInfraestructura.Location = new Point(-4, 119);
            btnInfraestructura.Margin = new Padding(4, 3, 4, 3);
            btnInfraestructura.Name = "btnInfraestructura";
            btnInfraestructura.Padding = new Padding(41, 0, 0, 0);
            btnInfraestructura.Size = new Size(287, 23);
            btnInfraestructura.TabIndex = 5;
            btnInfraestructura.Text = "InfraEstructura";
            btnInfraestructura.TextAlign = ContentAlignment.MiddleLeft;
            btnInfraestructura.UseVisualStyleBackColor = true;
            btnInfraestructura.Click += btnInfraestructura_Click;
            // 
            // btnPiso
            // 
            btnPiso.Anchor = AnchorStyles.Top;
            btnPiso.FlatAppearance.BorderSize = 0;
            btnPiso.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnPiso.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnPiso.FlatStyle = FlatStyle.Flat;
            btnPiso.Font = new Font("Calibri Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPiso.ForeColor = SystemColors.ButtonHighlight;
            btnPiso.ImageAlign = ContentAlignment.MiddleLeft;
            btnPiso.Location = new Point(-2, 90);
            btnPiso.Margin = new Padding(4, 3, 4, 3);
            btnPiso.Name = "btnPiso";
            btnPiso.Padding = new Padding(41, 0, 0, 0);
            btnPiso.Size = new Size(287, 23);
            btnPiso.TabIndex = 4;
            btnPiso.Text = "Piso";
            btnPiso.TextAlign = ContentAlignment.MiddleLeft;
            btnPiso.UseVisualStyleBackColor = true;
            btnPiso.Click += btnPiso_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Gray;
            button3.FlatAppearance.MouseOverBackColor = Color.Silver;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Calibri Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-2, 60);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Padding = new Padding(41, 0, 0, 0);
            button3.Size = new Size(287, 23);
            button3.TabIndex = 3;
            button3.Text = "Sucursal";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Gray;
            button2.FlatAppearance.MouseOverBackColor = Color.Silver;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Calibri Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-2, 30);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Padding = new Padding(41, 0, 0, 0);
            button2.Size = new Size(287, 23);
            button2.TabIndex = 2;
            button2.Text = "Dimension";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            // 
            // btnTipoInfraestructura
            // 
            btnTipoInfraestructura.Anchor = AnchorStyles.Top;
            btnTipoInfraestructura.FlatAppearance.BorderSize = 0;
            btnTipoInfraestructura.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnTipoInfraestructura.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnTipoInfraestructura.FlatStyle = FlatStyle.Flat;
            btnTipoInfraestructura.Font = new Font("Calibri Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnTipoInfraestructura.ForeColor = SystemColors.ButtonHighlight;
            btnTipoInfraestructura.ImageAlign = ContentAlignment.MiddleLeft;
            btnTipoInfraestructura.Location = new Point(-2, 0);
            btnTipoInfraestructura.Margin = new Padding(4, 3, 4, 3);
            btnTipoInfraestructura.Name = "btnTipoInfraestructura";
            btnTipoInfraestructura.Padding = new Padding(41, 0, 0, 0);
            btnTipoInfraestructura.Size = new Size(287, 23);
            btnTipoInfraestructura.TabIndex = 1;
            btnTipoInfraestructura.Text = "Tipo de InfraEstructura";
            btnTipoInfraestructura.TextAlign = ContentAlignment.MiddleLeft;
            btnTipoInfraestructura.UseVisualStyleBackColor = true;
            btnTipoInfraestructura.Click += btnTipoInfraestructura_Click;
            // 
            // btnCatalogo
            // 
            btnCatalogo.FlatAppearance.BorderSize = 0;
            btnCatalogo.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnCatalogo.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnCatalogo.FlatStyle = FlatStyle.Flat;
            btnCatalogo.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCatalogo.ForeColor = SystemColors.ButtonHighlight;
            btnCatalogo.Image = (Image)resources.GetObject("btnCatalogo.Image");
            btnCatalogo.ImageAlign = ContentAlignment.MiddleLeft;
            btnCatalogo.Location = new Point(0, 129);
            btnCatalogo.Margin = new Padding(4, 3, 4, 3);
            btnCatalogo.Name = "btnCatalogo";
            btnCatalogo.RightToLeft = RightToLeft.No;
            btnCatalogo.Size = new Size(292, 35);
            btnCatalogo.TabIndex = 3;
            btnCatalogo.Text = "          Catalogo";
            btnCatalogo.TextAlign = ContentAlignment.MiddleLeft;
            btnCatalogo.UseVisualStyleBackColor = true;
            btnCatalogo.Click += btnCatalogo_Click;
            // 
            // btnMenu
            // 
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.Location = new Point(4, 3);
            btnMenu.Margin = new Padding(4, 3, 4, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(31, 27);
            btnMenu.SizeMode = PictureBoxSizeMode.Zoom;
            btnMenu.TabIndex = 1;
            btnMenu.TabStop = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(292, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 40);
            panel1.TabIndex = 1;
            // 
            // panelContenedor
            // 
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(292, 40);
            panelContenedor.Margin = new Padding(4, 3, 4, 3);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(850, 588);
            panelContenedor.TabIndex = 2;
            // 
            // FMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 628);
            Controls.Add(panelContenedor);
            Controls.Add(panel1);
            Controls.Add(MenuVertical);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FMenu";
            Text = "Space";
            MenuVertical.ResumeLayout(false);
            pCatalogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Button btnCatalogo;
        private System.Windows.Forms.Panel pCatalogo;
        private System.Windows.Forms.Button btnTipoInfraestructura;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnPersonaNatural;
        private System.Windows.Forms.Button btnInfraestructura;
        private System.Windows.Forms.Button btnPiso;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnMercaderia;
        private Button button1;
    }
}