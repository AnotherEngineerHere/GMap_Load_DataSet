using GMap_Load_DataSet.Model;
using System;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace GMap_Load_DataSet.GUI
{

    public partial class MapWindow : Form
    {
        public ListOffices f { get; }
        public MapWindow()
        {
            InitializeComponent();
            f = new ListOffices();
        }


        private void BtnImport_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] Data = File.ReadAllLines(openFileDialog.FileName);
                PutDataInTable(Data);
                BtnViewMap.Visible = true;
                addCategoriesComboBox.GetDepartments.Visible = true;
            }
            else
            {
                string message = "You did not selected any file please try again";
                string caption = "File Neede";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message,caption,buttons);
            }

        }

        private void PutDataInTable(string[] data)
        {
            listMapInformation1.GetListView.Columns.Add("", "MUNICIPIO");
            listMapInformation1.GetListView.Columns.Add("", "TELEFONO");
            listMapInformation1.GetListView.Columns.Add("", "EMAIL");
            listMapInformation1.GetListView.Columns.Add("", "DIRECCIÓN");
            listMapInformation1.GetListView.Columns.Add("", "HORARIO");
            listMapInformation1.GetListView.Columns.Add("", "DEPARTAMENTO");
            listMapInformation1.GetListView.Columns.Add("", "CODIGO POSTAL");           

            for (int i = 1; i < data.Length; i++)
            {
                string[] parts = data[i].Split(',');
                loadDataFromRow(parts);
                addCategoriesComboBox.Visible = true;
            }

        }

        private void loadDataFromRow(string[] parts)
        {

            string location = parts[0];
            string _phone = parts[1];
            string _mail = parts[2];
            string _dir = parts[3];
            string _town = parts[4];
            string _schedule = parts[5];
            string dpto = parts[6];
            string zipCode = parts[7];
            string lat = parts[8];
            string lon = parts[9];
            f.Add_List_Map(location, _phone, _mail, _dir, _town, _schedule, dpto, zipCode, lat, lon);
            listMapInformation1.GetListView.Rows.Add(location, _phone, _mail, _dir,_schedule,_town, zipCode);
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
            m.Of = f.Offices;
            m.Show();
        }
    }
}
