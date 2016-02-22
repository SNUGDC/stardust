using UnityEngine;
using System.Collections;

public class MetroSeatManControl : MonoBehaviour
{
    public GameObject Getup;

    public GameObject Seat;    void Start()
    {
        StartCoroutine(moveanim());

    }

    IEnumerator moveanim()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector3(1.5f, 0, 0);
        yield return new WaitForSeconds(2f);
        GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        GetComponent<SpriteRenderer>().sprite = Getup.GetComponent<SpriteRenderer>().sprite;
        yield return new WaitForSeconds(0.5f);
        GetComponent<SpriteRenderer>().sprite = Seat.GetComponent<SpriteRenderer>().sprite;


    }
}
