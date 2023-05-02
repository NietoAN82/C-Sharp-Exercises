using System.Collections.Generic;
namespace SortingExercises
{

    class Node
    {
        public Node left;
        public Node right;
        public int data;
    }
    class Program
    {
        
        /// <summary>
        /// This function searches through a list entered until a value x is found.
        /// </summary>
        /// <param name="elements"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        static int linearSearch(List<int> elements, int x)
        {
            int length = elements.Count;
            for (int i = 0; i < length; i++)
            {
                if (elements[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }

        static int binarySearch(List<int> elements, int x)
        {
            int start = 0;
            int stop = elements.Count - 1;
            int middle = (int)((start + stop) / 2);

            while (elements[middle] != x && start < stop) { 
                if(x < elements[middle])
                {
                    stop = middle - 1;
                }
                else
                {
                    start = middle + 1;
                }

                middle = (int)((start + stop) / 2);
            }

            return (elements[middle] != x) ? -1 : middle; //Return -1 or middle depending if x was found
        }
        int interpolationSearch(int[] arr, int length, int x)
        {
            int low = 0;
            int high = length - 1;
            while(low <= high && x >= arr[low] && x <= arr[high])
            {
                if(low == high)
                {
                    return low;
                }
                else
                {
                    return -1;
                }

                int pos = low + (high - low) / (arr[high] - arr[low]) * (x - arr[low]);

                if (arr[pos] == x)
                {
                    return pos;
                }

                if (arr[pos] < x)
                {
                    low = pos + 1;
                }
                else
                {
                    high = pos - 1;
                }
            }
            return -1;
        }

        public void DepthFirstSearchTraversalOnTree(Node root)
        {
            Stack<Node> nodes = new Stack<Node>();
            nodes.Push(root);
            while (nodes.Count > 0)
            {
                Node node = nodes.Pop();

                if (node.right != null)
                {
                    nodes.Push(node.right);
                }

                if (node.left != null)
                {
                    nodes.Push(node.left);
                }

                System.Diagnostics.Debug.WriteLine(" " + node.data);
            }
        }
        public void BreadthFirstTraversalOnTree(Node root)
        {
            Queue<Node> nodes = new Queue<Node>();
            if(root == null)
            {
                return;
            }

            nodes.Enqueue(root);
            while (nodes.Count > 0)
            {
                Node node = nodes.Dequeue();
                System.Diagnostics.Debug.WriteLine(" " + node.data);
                if(node.left != null)
                {
                    nodes.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    nodes.Enqueue(node.right);
                }
            }
        }

        /*public HashSet<int> BreadthFirstTraversalOnGraph(Node root)
        {
            HashSet<int> visited = new HashSet<int>();

            if (!graph.AdjacencyList.ContainsKey(root))
            {
                return visited;
            }

            Queue<int> q = new Queue<int>();
            q.Enqueue(root.data);
            while(q.Count > 0)
            {
                int vertex = q.Dequeue();

                if (visited.Contains(vertex))
                {
                    continue;
                }

                visited.Add(vertex);

                foreach(var neighbor in graph.AdjacencyList[vertex])
                {
                    if (!visited.Contains(neighbor))
                    {
                        q.Enqueue(neighbor);
                    }
                }
            }
            return visited;
        }*/
/*        public HashSet<int> DepthFirstSearchTraversalOnGraph(Node root)
        {
            HashSet<int> visited = new HashSet<int>();
            if (!graph.AdjacencyList.ContainsKey(root))
            {
                return visited;
            }

            Stack<int> stack = new Stack<int>();
            stack.Push(root.data);

            while (stack.Count > 0)
            {
                int vertex = stack.Pop();

                if (visited.Contains(vertex))
                {
                    continue;
                }

                visited.Add(vertex);

                foreach(var neighbor in graph.AdjacencyList[vertex]){
                    if(!visited.Contains(neighbor))
                    {
                        stack.Push(neighbor);
                    }
                }
            }

            return visited;
        }*/

        static int[] selectionSort(int[] arr)
        {
            int len = arr.Length;
            for (int i = 0; i < len; i++)
            {
                int minIndex = i;
                for (int j = 0; j < len; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
            return arr;
        }
        public static void Main(string[] args)
        {

            int[] example = new int[6] { 3, 1, 6, 2, 8, 0 };
            Array.Sort(example);
            foreach(int i in example)
            {
                System.Diagnostics.Debug.Write(i);
            }
            System.Diagnostics.Debug.Write("");
            //System.Diagnostics.Debug.WriteLine(Array.BinarySearch(example,6)); // returns index of value you're looking for
        }
    }
}