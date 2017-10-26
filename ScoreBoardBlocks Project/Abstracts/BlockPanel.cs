using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public abstract class BlockPanel : System.Windows.Forms.UserControl
    {
        private String name;
        public abstract void updateTextFile();

        public void setName(String name)
        {
            this.name = name;
        }
        public String toString()
        {
            return this.name;
        }
    }
}
