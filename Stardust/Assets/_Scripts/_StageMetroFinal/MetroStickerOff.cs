using UnityEngine;
using System.Collections;

public class MetroStickerOff : MonoBehaviour {

    public GameObject seatgirl;


    void OnMouseDown()
    {
        seatgirl.GetComponent<MetroSeatGirlMoveControl>().stickeron = false;
    }
}
