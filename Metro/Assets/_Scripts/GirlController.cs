using UnityEngine;
using System.Collections;

public class GirlController : MonoBehaviour {

    public bool Go = true;

    public float Velocity;

    void Start()
    {
        GetComponent<Animator>().SetTrigger("Girl");
    }

    void FixedUpdate()
    {
        if (Go == true)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(Velocity, 0, 0);
        }
        if (Go == false)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 0f, 0f);
        }
    }
}