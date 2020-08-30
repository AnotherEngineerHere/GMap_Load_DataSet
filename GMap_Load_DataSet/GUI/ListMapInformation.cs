using System.Windows.Forms;

namespace GMap_Load_DataSet.GUI
{
    public partial class ListMapInformation : UserControl
    {
        public ListMapInformation()
        {
            InitializeComponent();
        }

        public DataGridView GetListView { get { return listMap; } }
    }
}
