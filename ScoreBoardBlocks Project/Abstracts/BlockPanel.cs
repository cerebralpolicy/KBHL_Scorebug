using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public abstract class BlockPanel : System.Windows.Forms.UserControl
    {
        private String currentScenePath;
        private String name;

        public void setName(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return this.name;
        }
        public String toString()
        {
            return this.name;
        }

        public void makeTextFile()
        {
            using (File.Create(Path.Combine(this.currentScenePath, this.name + ".txt"))) { }
        }

        public void writeToFile(String value)
        {
            FileStream fs = new FileStream(Path.Combine(this.currentScenePath, this.name + ".txt"), FileMode.Truncate, FileAccess.Write);
            byte[] byteValue = new UTF8Encoding(true).GetBytes(value);
            fs.Write(byteValue, 0, byteValue.Length);
            fs.Close();
        }

        public void setScenePath(String scenePath)
        {
            this.currentScenePath = scenePath;
        }

        public abstract List<String> returnProperties();
        public abstract void applyProperties(List<String> properties);
    }
}
