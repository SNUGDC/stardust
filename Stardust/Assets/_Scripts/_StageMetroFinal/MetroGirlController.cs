using UnityEngine;
using System.Collections;

public class MetroGirlController : MonoBehaviour
{

    public bool Go = true;
    public bool faceRight = true;
    public float velocity;



    void Start()
    {
        GetComponent<Animator>().SetTrigger("Girl");
    }

    void LateUpdate()
    {
        gameObject.transform.eulerAngles = new Vector3();
        if (Go == true)
        {
            if (Input.GetMouseButton(0) == true)
            {
                if (Input.mousePosition.x > Screen.width *2/ 3 && faceRight == true)
                {
                    Vector3 girlPos = GetComponent<Transform>().position;
                    GetComponent<Transform>().position = girlPos + new Vector3(velocity * Time.deltaTime, 0, 0);
                }
                else if (Input.mousePosition.x < Screen.width / 3 && faceRight == false)
                {
                    Vector3 girlPos = GetComponent<Transform>().position;
                    GetComponent<Transform>().position = girlPos - new Vector3(velocity * Time.deltaTime, 0, 0);
                }
                else if (Input.mousePosition.x > Screen.width *2/ 3 && faceRight == false)
                {
                    Flip();
//					FlipTemp();
                }
                else if (Input.mousePosition.x < Screen.width / 3 && faceRight == true)
                {
                    Flip();
//					FlipTemp();
                }
            }

            else
            {
                Vector3 girlStopPos = GetComponent<Transform>().position;
                GetComponent<Transform>().position = girlStopPos;

            }

        }
        if (Go == false)
        {
            Vector3 girlStopPos = GetComponent<Transform>().position;
            GetComponent<Transform>().position = girlStopPos;
        }
    }

/*	void FlipTemp(){
		if (faceRight == true) {
			faceRight = false;
			transform.localRotation = Quaternion.Euler (0, 180, 0);
		} else if (faceRight == false) {
			
			faceRight = true;
			transform.localRotation = Quaternion.Euler (0, 0, 0);
		}
	}*/

    void Flip()
    {
        faceRight=GetComponent<SpriteRenderer>().flipX;
        GetComponent<SpriteRenderer>().flipX = !faceRight;
    }
}