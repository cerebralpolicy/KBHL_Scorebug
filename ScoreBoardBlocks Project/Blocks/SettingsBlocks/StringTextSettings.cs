using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class StringTextSettings : SettingsBlock
    {
        public StringTextSettings()
        {
            InitializeComponent();
        }

        public override BlockPanel makeNewBlockUsingSettings()
        {
            return new StringText(nameTextBox.Text);
        }
    }
}
