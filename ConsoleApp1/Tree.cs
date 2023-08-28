using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TreeNode<T>
    {
        public T data;
        public TreeNode<T> left;
        public TreeNode<T> right;
        public TreeNode(T data)
        {
            this.data = data;
            left = null;
            right = null;
        }
    }
    class Tree
    {
        //public TreeNode<int> Root;
        public TreeNode<int> Root { get; set; }
        public Tree()
        {
            Root = null;
        }
        
        public TreeNode<int> InsertNode(TreeNode<int> root, int data)
        {
            TreeNode<int> newNode = new TreeNode<int>(data);
            if(root == null)
            {
                root = newNode;
            }
            else if (data < root.data)
            {
                InsertNode(root.left, data);
            }else if(data> root.data)
            {
                InsertNode(root.right, data);
            }
            return root;
        }
        public void Insert(int data)
        {
            Root = InsertNode(Root, data);
        }

        public void InOrder(TreeNode<int> root)
        {
            if (root == null)
                return;
            InOrder(root.left);
            Console.WriteLine(root.data);
            InOrder(root.right);
        }
    }
}
