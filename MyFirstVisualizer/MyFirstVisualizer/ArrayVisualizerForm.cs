using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstVisualizer
{
    public partial class ArrayVisualizerForm : Form
    {
        public ArrayVisualizerForm(int[] Array)
        {
            InitializeComponent();
            LoadData(Array);
        }

        private void LoadData(int[] dataArr)
        {
            if (arrayDataGrid.Rows.Count > 0)
            {
                arrayDataGrid.Rows.Clear();
            }
            object[] rowData = Array.ConvertAll(dataArr, x => (object)x);
            for (int i = 0; i < rowData.Length; i++)
            {
                arrayDataGrid.Rows.Add(rowData[i]);
            }

        }
    }
}
