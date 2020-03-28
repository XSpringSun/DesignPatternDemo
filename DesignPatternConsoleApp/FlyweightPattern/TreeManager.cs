using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern
{
    public class TreeManager
    {
        List<TreeState> treeArray;
        private Tree treeObj;
        public TreeManager(List<TreeState> trees) {
            treeArray = trees;
            treeObj = new Tree();
        }

        public void DispalyTress() {
            foreach (var tree in treeArray)
            {
                treeObj.Display(tree.X, tree.Y, tree.Age);
            }
        }
    }
}
