using UnityEngine;
using System.Collections;

public class Throwingmush : MonoBehaviour {

    public GameObject Player;
    Animator Mushthrow;
    public Animator MoleGO;

    void Start()
    {
        Mushthrow = GetComponent<Animator>();
    }
    
    public void OnTriggerEnter2D (Collider2D other)
    {
        Debug.Log("colliderCheck");
        Mushthrow.SetBool("Throwmush", true);
        if (other.gameObject.tag == "player")
        {
            
            /*Debug.Log("player in");
            if(Player.GetComponent<Transform>().localScale == new Vector3(0.25f, 0.25f, 0))
            {
                Mushthrow.SetBool("Throwmush", true);
                Debug.Log("mush throw");
            }*/
        }
    }

    void MushthrowMakesMoleBig()
    {
        MoleGO.SetBool("Molemove", true);
    }
}
