using System;

namespace Exercise2
{
    class Node
    {
        public int Data;
        public Node left;
        public Node right;
    }

    class Program
    {
        static void InOrder(Node root)
        {
            if(root != null)
            {
                InOrder(root.left);
                System.Diagnostics.Debug.WriteLine(root.Data);
                InOrder(root.right);
            }
        }

        static void PreOrder(Node root)
        {
            if(root != null)
            {
                System.Diagnostics.Debug.WriteLine(root.Data);
                PreOrder(root.left);
                PreOrder(root.right);
            }
        }

        static void PostOrder(Node root)
        {
            if(root != null)
            {
                PostOrder(root.left);
                PostOrder(root.right);
                System.Diagnostics.Debug.WriteLine(root.Data);
            }
        }

        public static void Main(string[] args)
        {
            Node leftNode = new Node()
            {
                Data = 1,
                left = null,
                right = null
            };

            Node rightNode = new Node()
            {
                Data = 3,
                left = null,
                right = null
            };

            Node root = new Node()
            {
                Data = 2,
                left = leftNode,
                right = rightNode
            };

           PostOrder(root);
        }

        
    }
}