using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.DebuggerVisualizers;
using System.Windows.Forms;
using System.IO;

[assembly: System.Diagnostics.DebuggerVisualizer(
typeof(MyFirstVisualizer.DebuggerSide),
typeof(VisualizerObjectSource),
Target = typeof(int[]),
Description = "My First Visualizer")]


namespace MyFirstVisualizer
{
    [Obsolete]
    public class DebuggerSide : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            int[] arr = objectProvider.GetObject() as int[];
            ShowArray(arr);

        } 
        private void ShowArray(int[] array)
        {
            ArrayVisualizerForm arrayForm=
                new ArrayVisualizerForm(array);
            arrayForm.ShowDialog();
            MessageBox.Show("Process completed");
    }

        public static void TestShowVisualizer(object objectToVisualize)
        {
            VisualizerDevelopmentHost visualizerHost = new VisualizerDevelopmentHost(objectToVisualize, typeof(DebuggerSide));
            visualizerHost.ShowVisualizer();
        }
    }
}
