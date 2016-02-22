using UnityEngine;
using System.Collections;

public class MetroPinkSeatManSitDwon : MonoBehaviour
{

    public GameObject sitdown;
    public GameObject suit;
    // Update is called once per frame
    void Start()
    {
        Debug.Log(33);
        this.gameObject.SetActive(false);
        sitdown.SetActive(true);

    }
}
