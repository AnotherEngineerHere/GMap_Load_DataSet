using System;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace GMap_Load_DataSet.GUI
{

    public partial class MapWindow : Form
    {
        public MapWindow()
        {
            InitializeComponent();
        }


        private void BtnImport_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK) { }
            {
                string[] Data = File.ReadAllLines(openFileDialog.FileName);
                PutDataInTable(Data);
            }

        }

        private void PutDataInTable(string[] data)
        {
           
        }

        public void LoadDataFromFileToComboBox(String d)
        {
            if (addCategoriesComboBox.GetDepartments.SelectedValue.ToString() == d)
            {
                //addCategoriesComboBox.LoadPossibleValues()
            }
           
        }

        private void BtnViewMap_Click(object sender, EventArgs e)
        {
            Map m = new Map();
            m.Show();
        }
    }
}
