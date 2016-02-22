using UnityEngine;
using System.Collections;

public class MetroAirconStrongOff : MonoBehaviour {

    public GameObject capman;

    void OnMouseDown()
    {
        capman.GetComponent<MetroCapManStar>().airconstrong = false;
    }
}
