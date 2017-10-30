using ScoreBoardBlocksOBS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    [Serializable]
    public class Scene
    {
        protected String name;
        protected String folderPath;
        protected List<List<String>> stringBlocksArray;

        [field:NonSerialized]
        private List<BlockPanel> blocksArray;

        [field:NonSerialized]
        protected MainForm mainWindow;

        public Scene(MainForm mainWindow)
        {
            this.blocksArray = new List<BlockPanel>();
            this.name = "New Scene";
            this.folderPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Output\\" + this.name);
            this.mainWindow = mainWindow;
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

        public void activateBlocks()
        {
            if (!Directory.Exists(this.folderPath))
            {
                Directory.CreateDirectory(this.folderPath);
            }

            for (int x = 0; x < blocksArray.Count; x++)
            {
                blocksArray[x].makeTextFile();
            }
        }

        public void prepareForSave()
        {
            this.stringBlocksArray = new List<List<string>>();

            for (int x = 0; x < this.blocksArray.Count; x++)
            {
                List<String> block = new List<String>();
                block.Add(Convert.ToString(this.blocksArray[x].GetType()));
                block.AddRange(this.blocksArray[x].returnProperties());

                this.stringBlocksArray.Add(block);
            }
        }

        public void prepareForLoad()
        {
            this.blocksArray = new List<BlockPanel>();

            for (int x = 0; x < this.stringBlocksArray.Count; x++)
            {
                Type type = Type.GetType(this.stringBlocksArray[x][0]);
                BlockPanel newBlock = (BlockPanel)Activator.CreateInstance(type);
                newBlock.applyProperties(this.stringBlocksArray[x]);

                this.blocksArray.Add(newBlock);
            }
        }

    }
}
