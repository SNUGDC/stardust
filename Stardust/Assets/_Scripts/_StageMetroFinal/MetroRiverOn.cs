using UnityEngine;
using System.Collections;

public class MetroRiverOn : MonoBehaviour
{

    public GameObject river;

    void OnMouseDown()
    {
        river.GetComponent<MetroRiver>().riveron = true;
    }
}