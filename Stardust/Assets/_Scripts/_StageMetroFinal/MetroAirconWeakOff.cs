using UnityEngine;
using System.Collections;

public class MetroAirconWeakOff : MonoBehaviour {

    public GameObject seatgirl;

    void OnMouseDown()
    {
        seatgirl.GetComponent<MetroSeatGirlMoveControl>().airconweak = false;
    }
}
