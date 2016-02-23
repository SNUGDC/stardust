using UnityEngine;
using System.Collections;

public class Throwingmush : MonoBehaviour {

    public GameObject Player;
    public GameObject Must_ToThrow;
    public Animator Mushthrow;
    
    public void OnTriggerEnter2D (Collider2D other)
    {
        Debug.Log("colliderCheck");
            if(scaleSmaller.scaled == true)
            {
            Must_ToThrow.SetActive(true);
            //Mushthrow.SetBool("Throwmush", true);
                Debug.Log("mush throw");
            }
        }
    }
