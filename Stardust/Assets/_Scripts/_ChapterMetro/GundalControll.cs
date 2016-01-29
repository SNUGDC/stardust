using UnityEngine;
using System.Collections;

public class GundalControll : MonoBehaviour {

    public GameObject Gundal;
    public GameObject Grandpa;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Girl")
        {
            Grandpa.GetComponent<Collider2D>().enabled = true;
            Gundal.GetComponent<Transform>().localScale = new Vector3(1,1,1);
        }
    }
}
