namespace Space.Desk.Formulario.Infraestructura
{
    partial class InfraestructuraMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfraestructuraMain));
            this.label1 = new System.Windows.Forms.Label();
            this.GridListInfraestructura = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridListInfraestructura)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Infraestructura";
            // 
            // GridListInfraestructura
            // 
            this.GridListInfraestructura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridListInfraestructura.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.GridListInfraestructura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridListInfraestructura.GridColor = System.Drawing.SystemColors.Window;
            this.GridListInfraestructura.Location = new System.Drawing.Point(9, 78);
            this.GridListInfraestructura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridListInfraestructura.MultiSelect = false;
            this.GridListInfraestructura.Name = "GridListInfraestructura";
            this.GridListInfraestructura.ReadOnly = true;
            this.GridListInfraestructura.RowHeadersWidth = 51;
            this.GridListInfraestructura.RowTemplate.Height = 24;
            this.GridListInfraestructura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridListInfraestructura.Size = new System.Drawing.Size(1376, 593);
            this.GridListInfraestructura.TabIndex = 10;
            this.GridListInfraestructura.DoubleClick += new System.EventHandler(this.GridListInfraestructura_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.Image")));
            this.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevo.Location = new System.Drawing.Point(1339, 15);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(47, 43);
            this.BtnNuevo.TabIndex = 14;
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(1281, 15);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(49, 43);
            this.btnActualizar.TabIndex = 15;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // InfraestructuraMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1400, 738);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridListInfraestructura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InfraestructuraMain";
            this.Text = "InfraestructuraMain";
            this.Load += new System.EventHandler(this.InfraestructuraMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridListInfraestructura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridListInfraestructura;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button btnActualizar;
    }
}