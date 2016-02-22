using UnityEngine;
using System.Collections;

public class MetroDucklingsMove : MonoBehaviour
{

    public GameObject wheretogo;
    Vector3 ducklingpos;
    float speed = 1.5f;
    public GameObject brownduck;
    public GameObject brownduckswitch;

    void Start()
    {

    }

    void Update()
    {
        if (brownduckswitch.GetComponent<MetroBrownDuckSwitch>().brownduckon == true)
        {
            if (brownduck.GetComponent<MetroBrownDuckMove>().ducklingmove == true)
            {
                Destroy(GetComponentInParent<BoxCollider2D>());
                
                if (transform.position.x > wheretogo.transform.position.x)
                {
                    ducklingpos = Vector3.MoveTowards(transform.position, wheretogo.transform.position, speed * Time.deltaTime);
                    transform.position = ducklingpos;
                }
            }
        }
    }
}