using UnityEngine;
using System.Collections;

public class MetroPinkSeatManSitDwon : MonoBehaviour
{

    public GameObject sitdown;
    public GameObject suit;
    public GameObject seat;

    // Update is called once per frame
    private void Update()
    {
        if (seat.GetComponent<MetroTargetExchanger>().active == false)
        {

            this.gameObject.SetActive(false);
            sitdown.SetActive(true);

        }
    }

}
