using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Image HealtBar;
    Animator anim;

    public float Health = 6;
    public int HalfCounter;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

   
    void Update()
    {
        if(Health <= 0)
        {
            anim.SetTrigger("Death");
            gameObject.GetComponentInParent<hareket>().ControlMove(false);
        }
    }
    public void Healthchange(float HealthchangeValue)
    {
        Health -= HealthchangeValue;
        if(Health % 2 == 0 && Health !=6)
        {
            HalfCounter = 2;
        }
        else
        {
            HalfCounter = 0;
        }
     
        HealthchangeValue = (3.5f * HealthchangeValue + HalfCounter) / 25;
        HealtBar.fillAmount -= HealthchangeValue;


    }
}
