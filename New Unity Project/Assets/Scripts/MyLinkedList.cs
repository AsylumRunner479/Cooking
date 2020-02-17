using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLinkedList
{
    public Node Header;
    Node Current;
    // Start is called before the first frame update
    public MyLinkedList(GameObject d)
    {
        Header = new Node(d);
        Current = Header;
    }
    public GameObject GetCurrent()
    {
        return Current.data;
    }

    public void Add(GameObject d)
    {
        Node newNode = new Node(d);
        newNode.nextNode = Current.nextNode;
        Current.nextNode = newNode;
    }
    // Update is called once per frame
    public void AddFirst(GameObject d)
    {

    }
    public void RemoveNext()
    {
        Node tempNode = Current.nextNode;
        Current.nextNode = Current.nextNode.nextNode;
        tempNode = null;
    }
   public void MoveToNext()
    {
        if (Current.nextNode != null)
        {
            Current = Current.nextNode;
        }
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
