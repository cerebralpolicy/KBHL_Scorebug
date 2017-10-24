using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Blocks
{
    public partial class IncrementalNumerical : BlockPanel
    {
        String name;
        int customInterval;
        bool ordinal;

        int currentValue;
        public IncrementalNumerical()
        {
            InitializeComponent();
        }

        public IncrementalNumerical(String name, int customInterval, bool ordinal)
        {
            InitializeComponent();
            this.name = name;
            groupBox.Text = name;
            this.customInterval = customInterval;
            plusCustomButton.Text = "+" + this.customInterval;
            minusCustomButton.Text = "-" + this.customInterval;
            this.ordinal = ordinal;
            this.currentValue = 0;

        }

        public override void updateTextFile()
        {
            
        }
    }
}
