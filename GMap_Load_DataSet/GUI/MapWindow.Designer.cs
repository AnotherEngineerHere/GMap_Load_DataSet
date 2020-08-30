namespace GMap_Load_DataSet.GUI
{
    partial class MapWindow
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
            this.BtnImport = new System.Windows.Forms.Button();
            this.BtnViewMap = new System.Windows.Forms.Button();
            this.listMapInformation1 = new GMap_Load_DataSet.GUI.ListMapInformation();
            this.addCategoriesComboBox = new GMap_Load_DataSet.GUI.AddCategoriesComboBox();
            this.SuspendLayout();
            // 
            // BtnImport
            // 
            this.BtnImport.Location = new System.Drawing.Point(703, 67);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(100, 48);
            this.BtnImport.TabIndex = 1;
            this.BtnImport.Text = "Import";
            this.BtnImport.UseVisualStyleBackColor = true;
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click_1);
            // 
            // BtnViewMap
            // 
            this.BtnViewMap.Location = new System.Drawing.Point(703, 12);
            this.BtnViewMap.Name = "BtnViewMap";
            this.BtnViewMap.Size = new System.Drawing.Size(100, 49);
            this.BtnViewMap.TabIndex = 5;
            this.BtnViewMap.Text = "View Map";
            this.BtnViewMap.UseVisualStyleBackColor = true;
            this.BtnViewMap.Click += new System.EventHandler(this.BtnViewMap_Click);
            // 
            // listMapInformation1
            // 
            this.listMapInformation1.Location = new System.Drawing.Point(25, 121);
            this.listMapInformation1.Name = "listMapInformation1";
            this.listMapInformation1.Size = new System.Drawing.Size(800, 600);
            this.listMapInformation1.TabIndex = 4;
            // 
            // addCategoriesComboBox
            // 
            this.addCategoriesComboBox.Location = new System.Drawing.Point(113, 12);
            this.addCategoriesComboBox.Name = "addCategoriesComboBox";
            this.addCategoriesComboBox.Size = new System.Drawing.Size(413, 103);
            this.addCategoriesComboBox.TabIndex = 3;
            // 
            // MapWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 681);
            this.Controls.Add(this.BtnViewMap);
            this.Controls.Add(this.listMapInformation1);
            this.Controls.Add(this.addCategoriesComboBox);
            this.Controls.Add(this.BtnImport);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MapWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MapWindow";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnImport;
        private AddCategoriesComboBox addCategoriesComboBox;
        private ListMapInformation listMapInformation1;
        private System.Windows.Forms.Button BtnViewMap;
    }
}