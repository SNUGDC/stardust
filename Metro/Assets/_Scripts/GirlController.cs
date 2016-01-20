using UnityEngine;
using System.Collections;

public class GirlController : MonoBehaviour {

    public bool Go = false;

    public float Velocity;

    void Update()
    {
        if (Go == true)
        {
            Debug.Log("aa");
            GetComponent<Rigidbody2D>().velocity = new Vector3(Velocity, 0, 0);
        }
    }
}
