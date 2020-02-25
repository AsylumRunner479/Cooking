using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlingShotManager : MonoBehaviour
{
    public SpringJoint spring1, spring2;
    public GameObject self;
    public bool launch = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
            //launch = false;
        //}      
        if (self.transform.localPosition.y >= 10)
        {
            //Destroy(spring1);
            //Destroy(spring2);
            //launch = true;
        }
        else
        {
//if (Input.GetMouseButtonDown(0) && launch == false)
            //{
               // Vector3 pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
               // self.transform.position = pos;
           // }
            
        }
    }
}
