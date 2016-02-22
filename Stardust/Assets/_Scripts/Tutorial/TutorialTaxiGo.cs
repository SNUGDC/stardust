using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TutorialTaxiGo : MonoBehaviour
{

    public GameObject girl;
    public GameObject wheretogo1;
    public GameObject wheretogo2;
    public GameObject wheretogo3;
    public GameObject wheretogo4;
    public GameObject wheretogo5;
    public GameObject girlontaxi;
    public GameObject text;
    private Vector3 temp;
    private Vector3 temp2;
    public float speed1;
    private float t=0;

    private void Start()
    {
        girl.GetComponent<TutorialPlayerController>().Go = false;
        Destroy(girl.GetComponent<Rigidbody2D>());
    }

    private void Update()
    {

        if (girl.transform.position.x < wheretogo1.transform.position.x)
        {

            temp = Vector3.MoveTowards(girl.transform.position, wheretogo1.transform.position, speed1*Time.deltaTime);
            girl.transform.position = temp;
        }

        else if (girl.transform.position.x < wheretogo2.transform.position.x)
        {

            temp = Vector3.MoveTowards(girl.transform.position, wheretogo2.transform.position, speed1 * Time.deltaTime);
            girl.transform.position = temp;
        }
        else if (girl.transform.position.x < wheretogo3.transform.position.x)
        {

            temp = Vector3.MoveTowards(girl.transform.position, wheretogo3.transform.position, speed1 * Time.deltaTime);
            girl.transform.position = temp;
        }


        else if (girl.transform.position.x < wheretogo4.transform.position.x)
        {
            girl.SetActive(false);
            girlontaxi.SetActive(true);
            
            temp = Vector3.MoveTowards(girlontaxi.transform.position, wheretogo4.transform.position, t);
            girlontaxi.transform.position = temp;
            temp2 = Vector3.MoveTowards(transform.position, wheretogo5.transform.position, t);
            transform.position = temp2;
            t += 0.003f;
        }

        else if (transform.position.x == wheretogo5.transform.position.x)
        {
            text.GetComponent<Text>().text = "Tutorial Stage Cleared!";
        }
    }
    
}