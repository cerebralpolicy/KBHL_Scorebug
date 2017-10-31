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

        public StringText()
        {
            InitializeComponent();
        }

        public StringText(String name)
        {
            InitializeComponent();
            this.groupBox.Text = name;
            setName(name);

        }

        public override string ToString()
        {
            return base.ToString();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            writeToFile(changeTextBox.Text);
            currentTextBox.Text = changeTextBox.Text;
        }

        public override List<string> returnProperties()
        {
            List<String> properties = new List<String>();
            properties.Add(this.getName());
            properties.Add(currentTextBox.Text);
            return properties;
        }

        public override void applyProperties(List<String> properties)
        {
            this.setName(properties[1]);
            this.groupBox.Text = getName();
            currentTextBox.Text = properties[2];
        }
    }
}
