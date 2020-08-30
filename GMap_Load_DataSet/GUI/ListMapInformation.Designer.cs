namespace GMap_Load_DataSet.GUI
{
    partial class ListMapInformation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listMap = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listMap)).BeginInit();
            this.SuspendLayout();
            // 
            // listMap
            // 
            this.listMap.AllowUserToAddRows = false;
            this.listMap.AllowUserToDeleteRows = false;
            this.listMap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listMap.Location = new System.Drawing.Point(0, 0);
            this.listMap.Name = "listMap";
            this.listMap.ReadOnly = true;
            this.listMap.Size = new System.Drawing.Size(800, 600);
            this.listMap.TabIndex = 0;
            this.listMap.AutoGenerateColumns = true;
            // 
            // ListMapInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listMap);
            this.Name = "ListMapInformation";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.listMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listMap;
    }
}
