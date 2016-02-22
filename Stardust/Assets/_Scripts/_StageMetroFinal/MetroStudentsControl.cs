using UnityEngine;
using System.Collections;

public class MetroStudentsControl : MonoBehaviour
{

    public GameObject wheretogo;
    public float smoothtime = 0.8f;
    Vector3 velocity;
    public GameObject suit;
    public bool changedtosuit = false;

    void Start()
    {
        StartCoroutine(Wait(1f));

        velocity = new Vector3();
        GetComponent<SpriteRenderer>().sprite = suit.GetComponent<SpriteRenderer>().sprite;

        changedtosuit = true;

        Destroy(GetComponentInParent<BoxCollider2D>());
    }


    void Update()
    {
        Vector3 newPosition = Vector3.SmoothDamp(transform.position, wheretogo.transform.position, ref velocity, smoothtime);
        transform.position = newPosition;
    }

    IEnumerator Wait(float waittime)
    {
        yield return new WaitForSeconds(waittime);
    }
}
