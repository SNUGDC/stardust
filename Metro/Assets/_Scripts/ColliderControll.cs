using UnityEngine;
using System.Collections;

public class ColliderControll : MonoBehaviour {


    public GameObject Girl;
    public bool Condition = false;
    public bool Go = false;

    void Update()
    {
        if (Go && Condition)
        {
            Girl.GetComponent<GirlController>().Go = true;
            Girl.GetComponent<Animator>().SetTrigger("Girl");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Girl")
        {
            Girl.GetComponent<GirlController>().Go = false;
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
