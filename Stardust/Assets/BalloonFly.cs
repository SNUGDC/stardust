using UnityEngine;
using System.Collections;

public class BalloonFly : MonoBehaviour
{

    public GameObject Fan;
    public GameObject RabbitBright;

    public float speed = 5;

	void Update () {

	    if (Fan.GetComponent<PanRotate>().IsRotating && RabbitBright.activeInHierarchy == true)
	    {
            //transform.Translate(-speed * Time.deltaTime , 0f , 0f);
            GetComponent<Animator>().SetBool("Fly", true);
	    }
	
	}
}
