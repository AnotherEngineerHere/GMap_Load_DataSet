using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GMap_Load_DataSet.GUI
{
    public partial class MapWindow : Form
    {
        public MapWindow()
        {
            InitializeComponent();
        }


        DataView ImportData(String fileName)
        {


            string title = "472-Colombian Oficces";

            DataSet ds = new DataSet();


            ds.Tables.Add(title);
            ds.Tables[title].Columns.Add("UBICACIÓN");
            ds.Tables[title].Columns.Add("TELEFONO");
            ds.Tables[title].Columns.Add("EMAIL");
            ds.Tables[title].Columns.Add("DIRECCIÓN");
            ds.Tables[title].Columns.Add("MUNICIPIO");
            ds.Tables[title].Columns.Add("HORARIO");
            ds.Tables[title].Columns.Add("DEPARTAMENTO");
            ds.Tables[title].Columns.Add("CODIGO POSTAL");
            ds.Tables[title].Columns.Add("LATITUD");
            ds.Tables[title].Columns.Add("LONGITUD");


            string[] lineas = File.ReadAllLines(fileName);



            for (int i = 1; i < lineas.Length; i++)
            {
                string[] celdas = Regex.Split(lineas[i], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

                int value = celdas.Length;

                ds.Tables[title].Rows.Add(celdas);

            }



            return ds.Tables[0].DefaultView;
        }



        private void buttImport_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                //Used like a filter: csv;

                Title = "Seleccionar Archivo"
            };

            //EN CASO DE SELECCIONAR EL ARCHIVO, ENTONCES PROCEDEMOS A ABRIR EL ARCHIVO CORRESPONDIENTE
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                listMap.GetDataGrid.DataSource = ImportData(openFileDialog.FileName);
            }
            addCategoriesComboBox.GetDepartments.Visible = true;
            BtnSearch.Visible = true;


        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (addCategoriesComboBox.GetDepartments.Text.Length > 0)
            {
                addCategoriesComboBox.GetPossibleFiles.Visible = true;
            }
        }
    }
}
