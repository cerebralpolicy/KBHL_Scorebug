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
    public partial class StringText : BlockPanel
    {
        String name;
        public StringText()
        {
            InitializeComponent();
        }

        public StringText(String name)
        {
            InitializeComponent();
            this.groupBox.Text = name;
            this.name = name;
        }

        public override void updateTextFile()
        {
            
        }
    }
}
