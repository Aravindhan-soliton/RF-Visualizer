using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViwerWpf
{
    class  VisualizerLogic
    {
        public ObservableCollection<int> data { get; set; } = new ObservableCollection<int>();
        public VisualizerLogic(int[] arr) { 
            foreach (int i in arr) {  data.Add(i); }
        }

    }
}
