using UnityEngine;
using System.Collections;

public class MetroAirconWeakOn : MonoBehaviour {

    public GameObject seatgirl;

    void OnMouseDown()
    {
        seatgirl.GetComponent<MetroSeatGirlMoveControl>().airconweak = true;
    }
}
