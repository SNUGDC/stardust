using UnityEngine;
using System.Collections;

public class RockMover : MonoBehaviour
{

    public GameObject Rat;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

	void Update () {

        if (Rat.GetComponent<RatMover>().actPhase == 2)
	    {
            rb.velocity = new Vector2(Rat.GetComponent<RatMover>().speed / 2, 0);
            transform.Rotate(0,0,-30*Time.deltaTime);
	    }
        else
        {
            rb.velocity = new Vector2(0f, 0f);
        }
	}
}
