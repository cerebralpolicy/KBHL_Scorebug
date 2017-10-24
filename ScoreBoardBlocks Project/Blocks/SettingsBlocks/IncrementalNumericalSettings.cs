using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Blocks.SettingsBlocks
{
    public partial class IncrementalNumericalSettings : SettingsBlock
    {
        public IncrementalNumericalSettings()
        {
            InitializeComponent();
        }

        public override BlockPanel makeNewBlockUsingSettings()
        {
            return new IncrementalNumerical(nameTextBox.Text, Convert.ToInt32(customIntervalTextBox.Text), ordinalCheckBox.Checked);
        }
    }
}
