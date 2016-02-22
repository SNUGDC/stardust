using UnityEngine;
using System.Collections;


public class TutorialPlayerController : MonoBehaviour
{


    public int QuestCount = 0;
    public float Speed;
    public bool facingRight = true;
    public bool Go = true;
    

    private void LateUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            MovePlayer();
        }
    }

    private void MovePlayer()
    {

        if (Go == true)
        {
            if (Input.mousePosition.x > (Screen.width*2/3) && facingRight)
            {
                transform.position = transform.position + new Vector3(Speed*Time.deltaTime, 0, 0);
            }
            else if (Input.mousePosition.x < (Screen.width/3) && !facingRight)
            {
                transform.position = transform.position - new Vector3(Speed*Time.deltaTime, 0, 0);
            }

            else if (Input.mousePosition.x > (Screen.width*2/3) && !facingRight)
            {
                Flip();
            }
            else if (Input.mousePosition.x < (Screen.width/3) && facingRight)
            {
                Flip();
            }
        }

        else
        {
            Vector3 PlayerStopPos = GetComponent<Transform>().position;
            transform.position = PlayerStopPos;
        }
    }

    private void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x = -theScale.x;
        transform.localScale = theScale;
    }


}












