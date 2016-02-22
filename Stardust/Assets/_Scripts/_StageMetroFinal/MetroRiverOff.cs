using UnityEngine;
using System.Collections;

public class MetroRiverOff : MonoBehaviour {


    public GameObject river;

    void OnMouseDown()
    {
        river.GetComponent<MetroRiver>().riveron = false;
    }
}
