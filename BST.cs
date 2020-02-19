using System;
using System.Threading;
using System.Collections.Generic;

namespace test
{
    public delegate int AddDel<T>(T a, T b);
    class Program
    {

        static void Main(string[] args)
        {
            BST s = new BST();
            s.insert(3); s.insert(13); s.insert(1); s.insert(4); s.insert(5); s.insert(2);

            s.Inorder(s.ReturnRoot());
            s.Serarch(s.ReturnRoot(),5);
        }
    }
}


public class Node
{
    public int data;
    public Node Left;
    public Node Right;
}
public class BST
{

    public Node root;
    public BST()
    {
        root = null;
    }
    public Node ReturnRoot()
    {
        return root;
    }
    public void Inorder(Node Root)
    {
        if (Root != null)
        {
            Inorder(Root.Left);
            Console.Write(Root.data + " ");
            Inorder(Root.Right);
        }
    }
    public void PreOrder(Node Root)
    {
        if(Root != null)
        {
            Console.Write(Root.data + " ");
            PreOrder(Root.Left);
            PreOrder(Root.Right);
        }
    }
    public void PostOrder(Node Root)
    {
        if(Root != null)
        {
            PreOrder(Root.Left);
            PreOrder(Root.Right);
            Console.Write(Root.data + " ");
        }
    }

    public void Serarch(Node s,int data)
    {
        if(s == null) Console.WriteLine("no element");
        if(s.data == data) Console.WriteLine("yes");
        else if(s.data > data){
            Serarch(s.Left,data);
        }
        else{
            Serarch(s.Right,data);
        }
    }
    public void insert(int data)
    {
        Node newNode = new Node();
        newNode.data = data;
        if (root == null)
        {
            root = newNode;
        }
        else
        {
            Node current = root;
            Node parent = null;

            while (true)
            {
                parent = current;

                if (data < current.data)
                {
                    current = current.Left;
                    if (parent.Left == null)
                    {
                        parent.Left = newNode;
                        break;
                    }
                }
                else
                {
                    current = parent.Right;
                    if (current == null)
                    {
                        parent.Right = newNode;
                        break;
                    }
                }

            }
        }
    }
}
