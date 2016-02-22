using UnityEngine;
using System.Collections;

public class MetroColliderControll : MonoBehaviour {


    public GameObject Girl;
    public bool Condition = false;
    public bool Go = false;

    void Update()
    {
        if (Go && Condition)
        {
            Girl.GetComponent<MetroGirlController>().Go = true;
            Girl.GetComponent<Animator>().SetTrigger("Girl");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Girl")
        {
            Girl.GetComponent<MetroGirlController>().Go = false;
            Girl.GetComponent<Animator>().SetTrigger("GirlStop");
            Go = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Girl")
        {
            Go = false;
        }
    }
}
