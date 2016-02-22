using UnityEngine;
using System.Collections;

public class MetroAirconStrongOn : MonoBehaviour {

    public GameObject capman;

    void OnMouseDown()
    {
        capman.GetComponent<MetroCapManStar>().airconstrong = true;
    }
}
