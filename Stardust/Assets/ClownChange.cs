using UnityEngine;
using System.Collections;

public class ClownChange : MonoBehaviour
{

    public GameObject Drunk;
    public GameObject Clown;
    public GameObject Star;

    void OnTriggerEnter2D(Collider2D balloon)
    {
        if (balloon.tag == "BalloonOne")
        {
            Drunk.SetActive(false);
            Clown.SetActive(true);
            Star.SetActive(true);
        }
    }

}
