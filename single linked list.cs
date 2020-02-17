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
           
           
           SingleLinkedList s = new SingleLinkedList();
           SingleLinkedList s1 = new SingleLinkedList();
           s1.InsertLast(s1,40);

           s.InsertLast(s,2);s.InsertLast(s,20);s.InsertLast(s,4);s.InsertLast(s,1);
           s.InsertFront(s,20);s.insertAfter(s,4,90);

          
          
s.printall(s);
        }
    }
}

public class Node {
    public int data;
    public Node next;
    public Node(int d)
    {
        data = d;
        next = null;
    }
    
}

public class SingleLinkedList {
    public Node head;
    public void InsertFront(SingleLinkedList s, int data)
    {
        Node new_node = new Node(data);
        new_node.next = s.head;
        s.head = new_node;
        
    }

    public void InsertLast(SingleLinkedList s, int data)
    {
        Node new_node = new Node(data);
        if(s.head == null){
            s.head = new_node;
            return;
        }

        Node lastNode = GetLastNode(s);
        lastNode.next = new_node;

    }

    private Node GetLastNode(SingleLinkedList s)
    {
        Node temp = s.head;
        while(temp.next != null){
            temp = temp.next;
        }
        return temp;
    }

    public void insertAfter(SingleLinkedList s,int data,int new_data)
    {
        Node temp = head;
        Node prev = null;

        Node new_node= new Node(new_data);

        if(temp.data == data)
        {
            new_node.next = head;
            head = new_node;
        }
        else{
            while(temp.data != data)
            {
                prev = temp;
                temp =temp.next;
            }
            new_node.next = prev.next;
            prev.next = new_node;
        }
        
    }


    public void printall(SingleLinkedList s)
    {
        Node temp = s.head;
        while(temp != null){
            Console.WriteLine(temp.data);
            temp = temp.next;
        }
    }

    public void DeletebyKey(SingleLinkedList s, int key)
    {
        Node temp = s.head;
        Node prev = null;

        if(temp != null && temp.data == key){
            s.head = temp.next;
            return;
        }
        while(temp !=null && temp.data != key)
        {
            prev = temp;
            temp = temp.next;
        }
        if(temp == null) return;
        prev.next = temp.next;
    }

    public void ReverseLikedList(SingleLinkedList s)
    {
        Node prev = null;
        Node current = s.head;
        Node temp = null;

        while(current != null)
        {
            temp = current.next;
            current.next = prev;
            prev = current;
            current = temp;
        }
        s.head= prev;
    }

    public void removeduplicate_sorted(SingleLinkedList s)
    {
        Node p = head;
        if(p == null) Console.WriteLine("no");

        else{
            while(p.next != null)
            {
                if(p.data == p.next.data)
                {
                    p.next = p.next.next;
                }
                else{
                    p = p.next;
                }
            }
        }
    }

    public void Sort_ll(SingleLinkedList s)
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

    public void merge(SingleLinkedList s1, SingleLinkedList s2)
    {
        SingleLinkedList s3 = null;
        Node n1 = s1.head;
        Node n2 = s2.head;
        
        while(n1!= null && n2!=null)
        {
            if(n1.data > n2.data)
            {
                s3.InsertLast(s2, n2.data);
                n2 = n2.next;
            }
            else{
                s3.InsertLast(s1, n1.data);
                n1 = n1.next;
            }
        }
        if(n1 == null)
        {
            while(n2 != null)
            {
                s3.InsertLast(s2, n2.data);
                n2 = n2.next;
            }
        }

        else{
            while(n1 != null)
            {
                s3.InsertLast(s1, n1.data);
                n1 = n1.next;
            }
        }

    }
}