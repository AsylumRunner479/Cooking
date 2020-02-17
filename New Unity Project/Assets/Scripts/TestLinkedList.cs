using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLinkedList : MonoBehaviour
{
    public GameObject testGameObject;
    public GameObject testGameObject1;

    MyLinkedList myList;
    // Start is called before the first frame update
    void Start()
    {
        myList = new MyLinkedList(testGameObject);
        myList.Add(testGameObject1);
        myList.MoveToNext();
        GameObject currentGO = myList.GetCurrent();
        currentGO.GetComponent<Renderer>().material.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
