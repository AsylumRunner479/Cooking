using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLinkedList
{
    Node Header;
    Node Previous;
    Node Current;
    Node LastNode;
    
    // Start is called before the first frame update
    public MyLinkedList(GameObject d)
    {
        Header = new Node(d);
        Previous = new Node(d);
        Current = Header;
        LastNode = Header;
    }
    public GameObject GetCurrent()
    {
        return Current.data;
    }
    public Node PeekNext()
    {
        if (Current.nextNode != null)
        {
            return Current.nextNode;
           

        }
        else
        {
            return Header;
        }
        
    }
    public Node PeekPrev()
    {
        if (Current.nextNode != Header)
        {
           
            return Previous;


        }
        else
        {
            return LastNode;
        }

    }

    public void Add(GameObject d)
    {
        Node newNode = new Node(d);
        newNode.nextNode = Current.nextNode;
        Current.nextNode = newNode;
    }
    public void AddPrev(GameObject d)
    {
        MoveToPrev();
        Node newNode = new Node(d);
        newNode.nextNode = Current.nextNode;
        Current.nextNode = newNode;
        MoveToNext();
        MoveToNext();
    }
    // Update is called once per frame
    public void AddFirst(GameObject d)
    {
        Node newNode = new Node(d);
        Header = LastNode;
    }
    public void RemoveNext()
    {
        Node tempNode = Current.nextNode;
        Current.nextNode = Current.nextNode.nextNode;
        tempNode = null;
    }
    public void RemovePrev()
    {
        MoveToNext();
        MoveToNext();
        Node tempNode = Current.nextNode;
        Current.nextNode = Current.nextNode.nextNode;
        tempNode = null;
    }
    public void MoveToNext()
    {
        if (Current.nextNode != null)
        {
            Previous = Current;
            Current = Current.nextNode;
        }
        else
        {
            Current = Header;
        }
    }
    public void MoveToPrev()
    {
        Previous = Header;
        if (Current != Header)
        {
            while (Previous.nextNode != Current)
            {
                Previous = Previous.nextNode;
            }
        }
        else
        {
            Previous = LastNode;
        }
        
        Current = Previous;

    }

}

public class Node
{
    public GameObject data;
    public Node nextNode;
    
    public Node(GameObject d)
    {
        data = d;
        nextNode = null;
    }

}
