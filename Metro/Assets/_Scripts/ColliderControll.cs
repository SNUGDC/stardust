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
        }
        else
        {
            Girl.GetComponent<GirlController>().Go = false;
        }
    }

    void OnTriggerEnter()
    {
        Go = true;
    }
}
