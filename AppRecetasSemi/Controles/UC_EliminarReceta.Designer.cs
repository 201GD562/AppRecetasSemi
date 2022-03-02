
namespace AppRecetas.Controles
{
    partial class UC_EliminarReceta
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.lstRecetas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.Location = new System.Drawing.Point(257, 275);
            this.btnconfirmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(82, 22);
            this.btnconfirmar.TabIndex = 3;
            this.btnconfirmar.Text = "Confirmar";
            this.btnconfirmar.UseVisualStyleBackColor = true;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // lstRecetas
            // 
            this.lstRecetas.FormattingEnabled = true;
            this.lstRecetas.ItemHeight = 15;
            this.lstRecetas.Items.AddRange(new object[] {
            "Remove"});
            this.lstRecetas.Location = new System.Drawing.Point(0, 0);
            this.lstRecetas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstRecetas.Name = "lstRecetas";
            this.lstRecetas.Size = new System.Drawing.Size(339, 274);
            this.lstRecetas.TabIndex = 2;
            // 
            // UC_EliminarReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.lstRecetas);
            this.Name = "UC_EliminarReceta";
            this.Size = new System.Drawing.Size(350, 300);
            this.Load += new System.EventHandler(this.UC_EliminarReceta_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnconfirmar;
        private System.Windows.Forms.ListBox lstRecetas;
    }
}
