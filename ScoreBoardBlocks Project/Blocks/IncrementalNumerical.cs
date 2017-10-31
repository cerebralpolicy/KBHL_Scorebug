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
            setName(name);
            groupBox.Text = name;
            this.customInterval = customInterval;
            plusCustomButton.Text = "+" + this.customInterval;
            minusCustomButton.Text = "-" + this.customInterval;
            this.ordinal = ordinal;
            this.currentValue = 0;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override List<string> returnProperties()
        {
            List<String> properties = new List<String>();
            properties.Add(this.getName());
            properties.Add(Convert.ToString(customInterval));
            properties.Add(Convert.ToString(ordinal));
            properties.Add(Convert.ToString(currentValue));
            return properties;
        }

        public override void applyProperties(List<String> properties)
        {
            this.setName(properties[1]);
            this.groupBox.Text = getName();
            this.customInterval = Convert.ToInt32(properties[2]);
            this.ordinal = Convert.ToBoolean(properties[3]);
            this.currentValue = Convert.ToInt32(properties[4]);
        }

        private void plusOneButton_Click(object sender, EventArgs e)
        {
            this.currentValue += 1;
            this.currentNumberTextBox.Text = this.currentValue.ToString();
            this.writeToFile(this.currentValue.ToString());
        }

        private void minusOneButton_Click(object sender, EventArgs e)
        {
            this.currentValue -= 1;
            this.currentNumberTextBox.Text = this.currentValue.ToString();
            this.writeToFile(this.currentValue.ToString());
        }

        private void plusCustomButton_Click(object sender, EventArgs e)
        {
            this.currentValue += this.customInterval;
            this.currentNumberTextBox.Text = this.currentValue.ToString();
            this.writeToFile(this.currentValue.ToString());
        }

        private void minusCustomButton_Click(object sender, EventArgs e)
        {
            this.currentValue -= this.customInterval;
            this.currentNumberTextBox.Text = this.currentValue.ToString();
            this.writeToFile(this.currentValue.ToString());
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            this.currentValue = 0;
            this.currentNumberTextBox.Text = this.currentValue.ToString();
            this.writeToFile(this.currentValue.ToString());
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            this.currentValue = Convert.ToInt32(this.quickChangeTextBox.Text);
            this.currentNumberTextBox.Text = this.currentValue.ToString();
            this.writeToFile(this.currentValue.ToString());
        }
    }
}
