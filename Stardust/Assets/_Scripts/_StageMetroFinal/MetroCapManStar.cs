using UnityEngine;
using System.Collections;

public class MetroCapManStar : MonoBehaviour
{


    public GameObject star;
    public GameObject wheretogo;
    public GameObject capoff;
    public bool airconstrong = false;
    public GameObject seatgirl;


    void Update()
    {
        if (airconstrong == true && seatgirl.GetComponent<MetroSeatGirlMoveControl>().stickeron == false)
        {
            star.SetActive(true);
            this.gameObject.SetActive(false);
            capoff.SetActive(true);
        }
    }
}