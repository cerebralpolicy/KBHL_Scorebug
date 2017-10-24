using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public abstract class SettingsBlock : System.Windows.Forms.UserControl
    {
        public abstract BlockPanel makeNewBlockUsingSettings();
    }
}
