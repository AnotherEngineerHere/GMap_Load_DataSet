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
            this.listMap.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.listMap.AllowUserToAddRows = false;
            this.listMap.AllowUserToDeleteRows = false;
            this.listMap.AllowUserToResizeColumns = false;
            this.listMap.AllowUserToResizeRows = false;
            this.listMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listMap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.listMap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listMap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listMap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.listMap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listMap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listMap.Location = new System.Drawing.Point(0, 0);
            this.listMap.Name = "listMap";
            this.listMap.ReadOnly = true;
            this.listMap.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.listMap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.listMap.Size = new System.Drawing.Size(800, 600);
            this.listMap.TabIndex = 0;
            this.listMap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listMap_CellContentClick);
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
