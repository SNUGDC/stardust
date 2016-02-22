using UnityEngine;
using System.Collections;

public class MetroSeatGirlMoveControl : MonoBehaviour
{

    public bool stickeron = false;
    public bool airconweak = false;
    public GameObject getup;
    public bool seatgirlgone=false;


    void Update()
    {
        if (stickeron == true && airconweak == true)
        {
            this.gameObject.SetActive(false);
            getup.SetActive(true);
            seatgirlgone = true;
        }
    }
}