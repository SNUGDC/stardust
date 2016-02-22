using UnityEngine;
using System.Collections;

public class MetroPinkSeatManMove : MonoBehaviour
{

    public GameObject wheretogo;
    float speed;
    Vector3 manpos;
    public GameObject stand;
    public GameObject suit;
    public GameObject goback;


    // Use this for initialization
    void Start()
    {
        speed = 0.8f;

    }

    // Update is called once per frame
    void Update()
    {
        if (suit.GetComponent<MetroStudentsControl>().changedtosuit == false)
        {
            StartCoroutine(Goback());
        }
        else if (suit.GetComponent<MetroStudentsControl>().changedtosuit == true)

        {

            if (transform.position.x < wheretogo.transform.position.x)
            {
                manpos = Vector3.MoveTowards(transform.position, wheretogo.GetComponent<Transform>().position, speed * Time.deltaTime);
                transform.position = manpos;
                Debug.Log(5);
            }

            else if (transform.position.x <= wheretogo.transform.position.x)
            {
                stand.SetActive(true);
                Destroy(this.gameObject);

                Debug.Log(6);
            }
        }
    }

    IEnumerator Goback()
    {
        yield return new WaitForSeconds(1f);
        this.gameObject.SetActive(false);
        goback.SetActive(true);
    }
}