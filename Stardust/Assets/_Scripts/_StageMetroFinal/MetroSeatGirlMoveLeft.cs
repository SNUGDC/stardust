using UnityEngine;
using System.Collections;

public class MetroSeatGirlMoveLeft : MonoBehaviour
{

    public GameObject wheretogo;
    Vector3 girlpos;
    float speed=1.5f;
    public GameObject stand;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > wheretogo.transform.position.x)
        {
            girlpos = Vector3.MoveTowards(transform.position, wheretogo.GetComponent<Transform>().position, speed * Time.deltaTime);
            transform.position = girlpos;
        }

        else
        {
            Destroy(this.gameObject);
            stand.SetActive(true);

        }
    }
}