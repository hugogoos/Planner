﻿using System.Text.Json;

namespace DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var minHeap = new MyselfMinHeap();
            minHeap.Init(8);
            minHeap.Push(7);
            Console.WriteLine();
            minHeap.LevelOrderTraversal();
            minHeap.Push(6);
            Console.WriteLine();
            minHeap.LevelOrderTraversal();
            minHeap.Push(5);
            Console.WriteLine();
            minHeap.LevelOrderTraversal();
            minHeap.Push(4);
            Console.WriteLine();
            minHeap.LevelOrderTraversal();
            minHeap.Push(3);
            Console.WriteLine();
            minHeap.LevelOrderTraversal();
            minHeap.Push(2);
            Console.WriteLine();
            minHeap.LevelOrderTraversal();
            minHeap.Push(1);
            Console.WriteLine();
            minHeap.LevelOrderTraversal();
            minHeap.Pop();
            Console.WriteLine();
            minHeap.LevelOrderTraversal();
            minHeap.Pop();
            Console.WriteLine();
            minHeap.LevelOrderTraversal();
            minHeap.Pop();
            Console.WriteLine();
            minHeap.LevelOrderTraversal();
            minHeap.Pop();
            Console.WriteLine();
            minHeap.LevelOrderTraversal();
            minHeap.Pop();
            Console.WriteLine();
            minHeap.LevelOrderTraversal();
            minHeap.Pop();
            Console.WriteLine();
            minHeap.LevelOrderTraversal();
            minHeap.Pop();
            Console.WriteLine();
            minHeap.LevelOrderTraversal();
            minHeap.Heapify(new int[8] { 8, 7, 6, 5, 4, 3, 2, 1 });
            Console.WriteLine();
            minHeap.LevelOrderTraversal();


            //var tree=new MyselfTreeLinkedList<int>();
            //tree.InitRoot(1);
            //tree.AddOrUpdateLeftChild(tree.Root, 2);
            //tree.AddOrUpdateRightChild(tree.Root, 3);
            //tree.AddOrUpdateLeftChild(tree.Root.Left, 4);
            //tree.AddOrUpdateRightChild(tree.Root.Left, 5);
            //tree.AddOrUpdateLeftChild(tree.Root.Right, 6);
            //tree.AddOrUpdateRightChild(tree.Root.Right, 7);
            //Console.WriteLine();
            //tree.PreOrderTraversal(tree.Root);
            //Console.WriteLine();
            //tree.InOrderTraversal(tree.Root);
            //Console.WriteLine();
            //tree.PostOrderTraversal(tree.Root);
            //Console.WriteLine();
            //tree.LevelOrderTraversal();
            //tree.Remove(tree.Root.Left);
            //Console.WriteLine();
            //tree.LevelOrderTraversal();
            //var tree = new MyselfTreeArray<int>();
            //tree.Init(7);
            //tree.AddOrUpdate(0, 1);
            //tree.AddOrUpdateLeftChild(1, 2);
            //tree.AddOrUpdateRightChild(1, 3);
            //tree.AddOrUpdateLeftChild(2, 4);
            //tree.AddOrUpdateRightChild(2, 5);
            //tree.AddOrUpdateLeftChild(3, 6);
            //tree.AddOrUpdateRightChild(3, 7);
            //Console.WriteLine();
            //tree.PreOrderTraversal();
            //Console.WriteLine();
            //tree.InOrderTraversal();
            //Console.WriteLine();
            //tree.PostOrderTraversal();
            //Console.WriteLine();
            //tree.LevelOrderTraversal();
            //tree.Remove(2);
            //Console.WriteLine();
            //tree.LevelOrderTraversal();

            Console.WriteLine("Hello, World!");
        }
    }
}
