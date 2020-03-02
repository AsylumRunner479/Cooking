using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLinkedList : MonoBehaviour
{
    public GameObject testGameObject;
    public GameObject testGameObject1;
    public GameObject testGameObject2;
    MyLinkedList myList;
    // Start is called before the first frame update
    void Start()
    {
        myList = new MyLinkedList(testGameObject);
        myList.Add(testGameObject1);
        myList.MoveToNext();
        myList.AddPrev(testGameObject2);
        myList.MoveToPrev();
        GameObject currentGO = myList.GetCurrent();
        currentGO.GetComponent<Renderer>().material.color = Color.green;
    }
    public void PrintEveryNode(MyLinkedList list)
    {
        list.ResetToHeader();
        do
        {
            Debug.Log(list.GetCurrent().name);
            list.MoveToNext();
        } while (true);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
