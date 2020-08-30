namespace GMap_Load_DataSet.GUI
{
    partial class AddCategoriesComboBox
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
            this.CategoriesCB = new System.Windows.Forms.ComboBox();
            this.PossibleValuesCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CategoriesCB
            // 
            this.CategoriesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoriesCB.FormattingEnabled = true;
            this.CategoriesCB.Location = new System.Drawing.Point(26, 41);
            this.CategoriesCB.Name = "CategoriesCB";
            this.CategoriesCB.Size = new System.Drawing.Size(121, 21);
            this.CategoriesCB.TabIndex = 0;
            this.CategoriesCB.SelectedIndexChanged += new System.EventHandler(this.CategoriesCB_SelectedIndexChanged);
            // 
            // PossibleValuesCB
            // 
            this.PossibleValuesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PossibleValuesCB.FormattingEnabled = true;
            this.PossibleValuesCB.Location = new System.Drawing.Point(26, 80);
            this.PossibleValuesCB.Name = "PossibleValuesCB";
            this.PossibleValuesCB.Size = new System.Drawing.Size(121, 21);
            this.PossibleValuesCB.TabIndex = 1;
            // 
            // AddCategoriesComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PossibleValuesCB);
            this.Controls.Add(this.CategoriesCB);
            this.Name = "AddCategoriesComboBox";
            this.Size = new System.Drawing.Size(159, 112);
            this.Load += new System.EventHandler(this.AddCategoriesComboBox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CategoriesCB;
        private System.Windows.Forms.ComboBox PossibleValuesCB;
    }
}
