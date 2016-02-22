using UnityEngine;
using System.Collections;

public class MetroStickerOn : MonoBehaviour {

	public GameObject seatgirl;

	
    void OnMouseDown()
    {
        seatgirl.GetComponent<MetroSeatGirlMoveControl>().stickeron = true;
    }
}
