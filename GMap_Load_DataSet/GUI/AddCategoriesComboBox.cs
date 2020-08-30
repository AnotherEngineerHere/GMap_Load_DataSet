using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMap_Load_DataSet.GUI
{
    public partial class AddCategoriesComboBox : UserControl
    {

        string[] _departments = { "BOGOTA D.C.", "CUNDINAMARCA", "BOYACA", "META", "AMAZONAS", "GUAINIA", "CASANARE", "CALDAS", "QUINDIO", "VALLE DEL CAUCA", "RISARALDA", "TOLIMA", "BOLIVAR", "GUAJIRA", "MAGDALENA", "ATLANTICO", "CORDOBA", "SUCRE", "NARIÑO", "ARAUCA", "PUTUMAYO", "CESAR", "SANTANDER", "NORTE DE SANTADER", "HUILA" };


        public AddCategoriesComboBox()
        {
            InitializeComponent();
        }
        /**
         *This method is used to access the values from the Combobox
         */
        public ComboBox GetPossibleFiles { get { return PossibleValuesCB; } }
        /**
         * This method allows to load the departments
         */
        public ComboBox GetDepartments { get { return CategoriesCB; } }


        private void AddCategoriesComboBox_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < _departments.Length; i++)
            {
                CategoriesCB.Items.Add(_departments[i]);
            }

        }

        private void CategoriesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetPossibleFiles.Visible = true;
        }

    }
}
