using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlingShotManager : MonoBehaviour
{
    public SpringJoint spring1, spring2;
    public GameObject self;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (self.transform.localPosition.y >= 6)
        {
            Destroy(spring1);
            Destroy(spring2);
        }
    }
}
