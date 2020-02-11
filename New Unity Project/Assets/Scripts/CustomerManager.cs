using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerManager : MonoBehaviour
{
    public GameObject self;
    private void OnTriggerStay(Collider other)
    {
        
        if (other.tag == "meal")
        {
            PlayerHandler.curStamina += 1;
            Destroy(self);

        }








    }
}
