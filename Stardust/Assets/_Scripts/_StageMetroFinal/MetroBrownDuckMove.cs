using UnityEngine;
using System.Collections;

public class MetroBrownDuckMove : MonoBehaviour
{

    public GameObject[] duckling;
    public GameObject river;
    public GameObject duckwheretogo_1;
    public GameObject duckwheretogo_2;
    public GameObject[] ducklingwheretogo;
    public GameObject star;
    Vector3 duckpos;
    Vector3 ducklingpos;
    float speed=1.5f;
    public bool ducklingmove=false;

    void Start()
    {
        
    }


    void Update()
    {
        if (river.GetComponent<MetroRiver>().riveron == true)
        {
            star.SetActive(true);

            if (transform.position.x > duckwheretogo_1.transform.position.x)
            {
                duckpos = Vector3.MoveTowards(transform.position, duckwheretogo_1.transform.position, speed * Time.deltaTime);
                transform.position = duckpos;
            }
            else
            {
                ducklingmove = true;

                duckpos = Vector3.MoveTowards(transform.position, duckwheretogo_2.transform.position, speed * Time.deltaTime);
                transform.position = duckpos;
            }

        }
    }
}
