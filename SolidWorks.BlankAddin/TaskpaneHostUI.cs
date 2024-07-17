using SolidWorks.BlankAddin1;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SolidWorks.BlankAddin1
{
    [ProgId(TaskpaneIntegration1.SWTASKPANE_PROGID)]
    public partial class TaskpaneHostUI : UserControl
    {
        public TaskpaneHostUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
