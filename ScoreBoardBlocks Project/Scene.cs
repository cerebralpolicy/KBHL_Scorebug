using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Scene
    {
        private List<BlockPanel> blocksArray;
        private String name;

        public Scene()
        {
            this.blocksArray = new List<BlockPanel>();
            this.name = "New Scene";
        }

        public void addBlock(BlockPanel block)
        {
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
    }
}
