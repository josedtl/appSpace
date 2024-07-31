namespace Space.Desk.Formulario.Mercaderia
{
    partial class MercaderiaMain
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
            GridListMercaderia = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)GridListMercaderia).BeginInit();
            SuspendLayout();
            // 
            // GridListMercaderia
            // 
            GridListMercaderia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridListMercaderia.BackgroundColor = Color.FromArgb(250, 250, 250);
            GridListMercaderia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridListMercaderia.GridColor = SystemColors.Window;
            GridListMercaderia.Location = new Point(12, 30);
            GridListMercaderia.Margin = new Padding(3, 2, 3, 2);
            GridListMercaderia.MultiSelect = false;
            GridListMercaderia.Name = "GridListMercaderia";
            GridListMercaderia.ReadOnly = true;
            GridListMercaderia.RowHeadersWidth = 51;
            GridListMercaderia.RowTemplate.Height = 24;
            GridListMercaderia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridListMercaderia.Size = new Size(768, 409);
            GridListMercaderia.TabIndex = 11;
            // 
            // MercaderiaMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GridListMercaderia);
            Name = "MercaderiaMain";
            Text = "MercaderiaMain";
            ((System.ComponentModel.ISupportInitialize)GridListMercaderia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GridListMercaderia;
    }
}