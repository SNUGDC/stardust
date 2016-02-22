using UnityEngine;
using System.Collections;

public class MetroBrownDuckOn : MonoBehaviour
{

    public GameObject brownduck;

    void OnMouseDown()
    {

        brownduck.GetComponent<MetroBrownDuckSwitch>().brownduckon = true;
    }
}