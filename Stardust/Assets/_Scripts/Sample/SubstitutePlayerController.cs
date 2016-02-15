using UnityEngine;
using System.Collections;

public class SubstitutePlayerController : MonoBehaviour
{

    public float movespeed;
    public bool facingRight = true;
    private Vector2 movedirection;
    Animator Girlmoveani;

    void Start()
    {
        //Vector2 currentpos = transform.position;
        Girlmoveani = GetComponent<Animator>();
    }

    void Update()
    {
        Vector2 currentpos = transform.position;

        if (Input.GetMouseButton(0))
        {
            Vector2 clickingpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            movedirection = clickingpos - currentpos;
            movedirection.Normalize();
            Vector2 target = movedirection * movespeed + currentpos;
            Vector2 Realtarget = new Vector2(target.x, transform.position.y);
            transform.position = Vector2.Lerp(currentpos, Realtarget, Time.deltaTime);

            if (currentpos.x > clickingpos.x)
            {
                if (facingRight == true)
                {
                    Flip();
                }

            }
            if (currentpos.x < clickingpos.x)
            {
                if (facingRight == false)
                {
                    Flip();
                }

                Girlmoveani.SetBool("Go", true);

                if (currentpos.x == clickingpos.x)
                {
                    Girlmoveani.SetBool("Go", false);
                }
            }
            else
            {
                Girlmoveani.SetBool("Go", false);
            }

            if (Input.GetMouseButtonUp(0))
            {
                Girlmoveani.SetBool("End", true);
            }
            else
            {
                Girlmoveani.SetBool("End", false);
            }

        }

    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x = -theScale.x;
        transform.localScale = theScale;
    }
}