using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodHandler : MonoBehaviour
{
    public GameObject self;
    public int foodType;
    public PlayerHandler player;
    void Start()
    {
        player = FindObjectOfType<PlayerHandler>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "player")
        {
            if (Input.GetKeyDown("e"))
            {
                if (PlayerHandler.hold == false)
                {
                    player.hand[foodType].SetActive(true);
                    PlayerHandler.hold = true;
                    PlayerHandler.item = foodType;
                    Destroy(self);

                }
                else if (PlayerHandler.item == foodType)
                {
                    
                    player.hand[PlayerHandler.item].SetActive(false);
                    PlayerHandler.hold = true;
                    player.hand[5].SetActive(true);
                    PlayerHandler.item = 5;
                    Debug.Log(foodType);
                    Destroy(self);
                }
            }
            
        }








    }
}
