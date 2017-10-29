using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    [Serializable]
    public class Scene
    {
        private List<BlockPanel> blocksArray;
        private String name;
        private String folderPath;

        public Scene()
        {
            this.blocksArray = new List<BlockPanel>();
            this.name = "New Scene";
            this.folderPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Output\\" + this.name);
        }

        public void addBlock(BlockPanel block)
        {
            block.setScenePath(this.folderPath);
            this.blocksArray.Add(block);
        }

        public void removeBlock(int x)
        {
            this.blocksArray.RemoveAt(x);
        }

        public List<BlockPanel> getBlockArray()
        {
            return this.blocksArray;
        }

        public String getName()
        {
            return this.name;
        }

        public void setName(String name)
        {
            this.name = name;
            for (int x = 0; x < blocksArray.Count; x++)
            {
                blocksArray[x].setScenePath(this.folderPath); 
            }
        }

        public String getFolderPath()
        {
            return this.folderPath;
        }

        public void setFolderPath(String path)
        {
            this.folderPath = path;
            for (int x = 0; x < blocksArray.Count; x++)
            {
                blocksArray[x].setScenePath(this.folderPath);
            }
        }
        
    }
}
