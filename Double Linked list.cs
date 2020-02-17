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
           
           
           DoubleLinkedList s = new DoubleLinkedList();

           s.InsertLast(s,2);s.InsertLast(s,20);s.InsertLast(s,4);s.InsertLast(s,1);
           s.InsertFront(s,20);s.insertAfter(s,4,90);

          
          
s.printall(s);
        }
    }
}

public class Node {
    public int data;
    public Node next;
    public Node prev;
    public Node(int d)
    {
        data = d;
        next = null;
        prev = null;
    }
    
}

public class DoubleLinkedList {
    public Node head;
    public void InsertFront(DoubleLinkedList d, int data)
    {
        Node new_node = new Node(data);
        new_node.next = d.head;
        new_node.prev = null;
        if(d.head != null)
        {
            d.head.prev = new_node;
        }
        d.head = new_node;
        
    }

    public void InsertLast(DoubleLinkedList d, int data)
    {
        Node new_node = new Node(data);
        if(d.head == null){
            new_node.prev = null;
            d.head = new_node;
            return;
        }

        Node lastNode = GetLastNode(d);
        lastNode.next = new_node;
        new_node.prev = lastNode;

    }

    private Node GetLastNode(DoubleLinkedList d)
    {
        Node temp = d.head;
        while(temp.next != null){
            temp = temp.next;
        }
        return temp;
    }

    public void insertAfter(DoubleLinkedList d,int data,int new_data)
    {
        Node temp = head;
        Node prev = null;

        Node new_node= new Node(new_data);

        if(temp.data == data)
        {
            head.prev = new_node;
            new_node.next = head;
            new_node.prev = null;
            head = new_node;
        }
        else{
            while(temp.data != data)
            {
                prev = temp;
                temp =temp.next;
            }
            new_node.next = prev.next.next;
            new_node.prev = prev;
            prev.next = new_node;
        }
        
    }


    public void printall(DoubleLinkedList d)
    {
        Node temp = d.head;
        while(temp != null){
            Console.WriteLine(temp.data);
            temp = temp.next;
        }
    }

    public void DeletebyKey(DoubleLinkedList d, int key)
    {
        Node temp = d.head;

        if(temp != null && temp.data == key){
            d.head = temp.next;
            d.head.prev = null;
            return;
        }
        while(temp !=null && temp.data != key)
        {
            temp = temp.next;
        }
        if(temp == null) return;
        if(temp.prev != null){
            temp.prev.next = temp.next;  // 1 2 3  delete 2 
        }
        if(temp.next != null){
            temp.next.prev = temp.prev;
        }
        
    }


    public void removeduplicate_sorted(DoubleLinkedList d)
    {
        Node p = head;
        if(p == null) Console.WriteLine("no");

        else{
            while(p.next != null)
            {
                if(p.data == p.next.data)
                {
                    p.next = p.next.next;
                    p.next.prev = p.next.next.prev;
                }
                else{
                    p = p.next;
                }
            }
        }
    }

    public void Sort_ll(DoubleLinkedList s)
    {
        Node i = head;
        Node j = null;
        int temp;
        for(i =head;i.next != null; i= i.next)
        {
            for(j= i.next; j!= null;j= j.next)
            {
                if(i.data > j.data)
                {
                    temp = i.data;
                    i.data = j.data;
                    j.data = temp;
                }
            }
        }
    }

}