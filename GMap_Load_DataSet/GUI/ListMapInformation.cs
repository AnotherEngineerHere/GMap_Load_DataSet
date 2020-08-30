using System.Windows.Forms;

namespace GMap_Load_DataSet.GUI
{
    public partial class ListMapInformation : UserControl
    {
        public ListMapInformation()
        {
            InitializeComponent();
        }

        public DataGridView GetDataGrid
        {
            get
            {
                return dataGridMap;
            }
        }

        private void dataGridMap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
