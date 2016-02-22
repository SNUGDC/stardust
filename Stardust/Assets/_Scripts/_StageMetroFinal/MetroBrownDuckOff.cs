using UnityEngine;
using System.Collections;

public class MetroBrownDuckOff : MonoBehaviour
{

    public GameObject brownduck;

    void OnMouseDown()
    {
        brownduck.GetComponent<MetroBrownDuckSwitch>().brownduckon = false;

    }
}