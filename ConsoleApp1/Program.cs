using ConsoleApp1.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        #region leet Code
        public static int[] TwoSum(int[] arr, int target)
        {
            Dictionary<int, int> nums = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                int complement = target - arr[i];
                if (nums.ContainsKey(complement))
                {
                    return new int[] { nums[complement], i };
                }
                nums[arr[i]] = i;
            }
            return new int[] { -1 };
        }
        //public static int[] TwoSum(int[] arr, int target)
        //{
        //    Dictionary<int, int> NumDictionary = new Dictionary<int, int>();
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        int complement = target - arr[i];

        //        if (NumDictionary.ContainsKey(complement))
        //        {
        //            return new int[] { NumDictionary[complement], i };
        //        }

        //        NumDictionary[arr[i]] = i;
        //    }
        //    return new int[2] { 1, 2 };
        //}
        //public static int[] ThreeSum(int[] arr, int target)
        //{
        //    Dictionary<int, int> nums = new Dictionary<int, int>();
        //    Dictionary<int, int> nums2 = new Dictionary<int, int>();
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        int complement = target - arr[i];
        //        if (nums.ContainsKey(complement))
        //        {
        //            return new int[] { nums[complement], i };
        //        }
        //        nums[arr[i]] = i;
        //    }
        //    return new int[] { -1 };
        //}
        #endregion
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "  ");
            }
            Console.WriteLine("");
        }
        public static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
        // Sorting Algorithms
        public static void SelectioSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i+1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                Swap(ref arr[minIndex], ref arr[i]);
            }
        }
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;
            for (int i = 0; i < n-1; i++)
            {
                swapped = false;
                for (int j = 0; j < n-i-1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                        swapped = true;
                    }
                }
                if (!swapped) break;
            }
        }
        public static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1; j > 0; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        Swap(ref arr[j], ref arr[j - 1]);
                    }
                }
            }
        }
        public static int[] MergeSort(int[] arr)
        {
            int n = arr.Length;
            if (n == 1)
            {
                return arr;
            }

            int mid = n / 2;
            int[] left = new int[mid];
            int[] right = new int[n - mid];

            // Copy elements from the original array to left and right arrays
            Array.Copy(arr, 0, left, 0, mid);
            Array.Copy(arr, mid, right, 0, n - mid);

            // Recursively sort the left and right subarrays
            left = MergeSort(left);
            right = MergeSort(right);

            // Merge the sorted left and right subarrays
            return MergeTwoSortedArrays(left, right);
        }
        public static int[] MergeTwoSortedArrays(int[] arr1, int[] arr2)
        {
            int n = arr1.Length;
            int m = arr2.Length;
            int[] res = new int[n+m];
            int i = 0;  // index for arr1
            int j = 0;  // index for arr2
            int x = 0;  // this index for looping in the result array
            while(i<n && j<m)
            {
                if (arr1[i] < arr2[j])
                {
                    res[x] = arr1[i++];
                }else if(arr1[i] > arr2[j])
                {
                    res[x] = arr2[j++];
                }else
                {
                    res[x] = arr1[i++];
                }
                x++;
            }
            while (i < n)
            {
                res[x++] = arr1[i++];
                // i++;
                // x++;
            }
            while (j < m)
            {
                res[x] = arr2[j];
                j++;
                x++;
            }
            return res;
        }
        // Searching Algorithms
        public static int BinarySearch(int[] arr, int value)
        {
            int n = arr.Length;
            int low = 0;
            int high = n - 1;
            int mid = (low + high) / 2;
            int midValue = arr[mid];
            while (low <= high)
            {
                if (midValue == value)
                {
                    return mid;
                }
                else if (value > midValue)
                {
                    low = mid + 1;
                    mid = (low + high) / 2;
                    midValue = arr[mid];
                }
                else if (value < midValue)
                {
                    high = mid - 1;
                    mid = (low + high) / 2;
                    midValue = arr[mid];
                }
            }
            return -1;
        }
        // Tree
        // Pre-Order Traversing
        public static void PreOrder(TreeNode<int> root)
        {
            if(root == null)
            {
                return;
            }
            Console.WriteLine(root.data);
            PreOrder(root.left);
            PreOrder(root.right);
        }
        public static void InOrder(TreeNode<int> root)
        {
            if (root == null)
            {
                return;
            }
            InOrder(root.left);
            Console.WriteLine(root.data);
            InOrder(root.right);
        }
        public static void PostOrder(TreeNode<int> root)
        {
            if(root != null)
            {
                PostOrder(root.left);
                PostOrder(root.right);
                Console.WriteLine(root.data);
            }
        }
        static void Main(string[] args)
        {
            #region Data Structures and Algorithms
            //Stack<char> s = new Stack<char>(5);
            //s.push('a');
            //s.push('v');
            //s.push('a');
            //s.push('s');
            //Console.WriteLine(s.pop());
            //Console.WriteLine(s.isEmpty());
            
            //Console.WriteLine("----------------------------");

            //int[] nums = { 20, 54, 21, 18, 5, 15, 19, 22 };
            //PrintArray(nums);
            ////SelectioSort(nums);
            ////BubbleSort(nums);
            //InsertionSort(nums);
            //PrintArray(nums);
            
            //Console.WriteLine("----------------------------");

            //Queue<int> q = new Queue<int>();
            //q.Enqueue(10);
            //q.Enqueue(20);
            //q.Enqueue(30);
            ////q.PrintQueue();
            //Console.WriteLine(q.Dequeue());
            //Console.WriteLine(q.Dequeue());
            //Console.WriteLine(q.Dequeue());

            //Console.WriteLine("----------------------------");

            //LinkedList<double> ll = new LinkedList<double>();
            //ll.AddLast(2.3);
            //ll.AddLast(56.9);
            //ll.AddLast(26.8);
            //ll.AddFirst(350.2);
            //ll.Print();
            //Console.WriteLine(ll.FindElement(20));
            //Console.WriteLine(ll.FindElementIndex(26.8));
            //ll.Reverse();
            //Console.WriteLine("----------------------------");
            //ll.Print();
            //Console.WriteLine("----------------------------");

            #endregion

            #region OOP


            Student ahmed = new Student("ahmed", 25, "123 st.", 4);
            ahmed.PrintData();



            #endregion

            #region Ds And Alg 2
            int[] arr1 = { 1, 2, 5, 11,15,21,75,88 };
            int[] arr2 = { 3, 4, 6, 10, 20 };
            int[] result;
            result = MergeTwoSortedArrays(arr1, arr2);
            //PrintArray(result);
            int[] arr3 = new int[3];
            Array.Copy(arr1, arr3, 3);
            PrintArray(arr3);

            int[] resul = MergeSort(new int[] { 20, 9, 5, 15, 24, 121, 59, 87, 56 });
            PrintArray(resul);


            int s = BinarySearch(resul, 121);
            Console.WriteLine(s);
            #endregion

            #region Tree
            Console.WriteLine("================== Tree");

            TreeNode<int> root = new TreeNode<int>(20);
            TreeNode<int> node2 = new TreeNode<int>(15);
            TreeNode<int> node3 = new TreeNode<int>(25);
            TreeNode<int> node4 = new TreeNode<int>(10);
            TreeNode<int> node5 = new TreeNode<int>(17);
            TreeNode<int> node6 = new TreeNode<int>(23);

            root.left = node2;
            root.right = node3;
            node2.left = node4;
            node2.right = node5;
            node3.left = node6;
            //System.Console.WriteLine(node3.left.data);

            // traversing the tree
            // Pre-Order Traversing
            //PreOrder(root);
            // In-Order Traversing
            //InOrder(root);
            // Post-Order Traversing
            PostOrder(root);
            #endregion

            #region Graph
            Console.WriteLine("================== Graph");

            Vertex v1 = new Vertex('a');
            Vertex v2 = new Vertex('b');
            Vertex v3 = new Vertex('c');
            Vertex v4 = new Vertex('d');
            Vertex v5 = new Vertex('e');
            Vertex v6 = new Vertex('f');

            Graph g = new Graph();
            g.AddVertex('a');
            g.AddVertex('b');
            g.AddVertex('c');
            g.AddVertex('d');
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(0, 3);
            g.AddEdge(1, 2);
            g.AddEdge(1, 3);
            g.AddEdge(2, 3);
            g.DisplayVertex(1);
            #endregion

            #region BST
            Console.WriteLine("================== BST");

            Tree t1 = new Tree();
            t1.InsertNode(t1.Root, 25);
            t1.InsertNode(t1.Root, 20);
            t1.InsertNode(t1.Root, 15);
            t1.InsertNode(t1.Root, 30);
            t1.InsertNode(t1.Root, 31);
            t1.InOrder(t1.Root);
            #endregion

            //int[] array = { 3, 5, 8, 1, 6 };
            //PrintArray(TwoSum(array, 13));
        }
    }
}
