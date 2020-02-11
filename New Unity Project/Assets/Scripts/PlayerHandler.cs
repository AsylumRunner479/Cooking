using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerHandler : MonoBehaviour
{
    public static bool isDead = false;
    public float curHealth, maxHealth;
    public static float curStamina, maxStamina;
    public Slider healthBar;
    public Slider staminaBar;
    public static bool hold;
    public GameManager manage;
    [SerializeField]
    public  GameObject[] hand;
    public static int item;
    public GameObject[] food;
    public GameObject dropZone;

    private void Start()
    {
        maxHealth = 100f;
        maxStamina = 4f;
        curHealth = maxHealth;
        curStamina = 0;

        healthBar.value = Mathf.Clamp01(curHealth / maxHealth);
        staminaBar.value = Mathf.Clamp01(curStamina / maxStamina);


    }

    // Update is called once per frame
    void Update()
    {
        curHealth -= 5*Time.deltaTime;
        if (Input.GetKeyDown("r"))
        {
            if (hold == true)
            {
                hand[item].SetActive(false);
                hold = false;
                
                
                    Instantiate(food[item], new Vector3(dropZone.transform.position.x, dropZone.transform.position.y, dropZone.transform.position.z), Quaternion.identity);
                

            }
        }

        
        if (curHealth / maxHealth != healthBar.value)
        {
            healthBar.value = Mathf.Clamp01(curHealth / maxHealth);
        }
        if (curStamina / maxStamina != staminaBar.value)
        {
            staminaBar.value = Mathf.Clamp01(curStamina / maxStamina);
        }



        
        if (curHealth <= 0)
        {
            Death();
        }





    }
    
    void LoseHealth()
    {
        curHealth = Mathf.Clamp(curHealth, 0, maxHealth);
        healthBar.value = Mathf.Clamp01(curHealth / maxHealth);

    }


    void Death()
    {

        isDead = true;




    }

    void Revive()
    {
        isDead = false;



    }







}

