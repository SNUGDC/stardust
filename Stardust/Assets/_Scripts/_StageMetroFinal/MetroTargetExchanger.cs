using UnityEngine;
using System.Collections;

public class MetroTargetExchanger : MonoBehaviour
{

    public GameObject Target;
    public GameObject ExchangedTarget1;
    public GameObject ExchangedTarget2;
    public bool seatmanmoved = false;
    public GameObject suit;
    public bool active = true;

    private void Start()
    {

    }

    private void Update()
    {
        if (active == true)
        {
            if (suit.GetComponent<MetroStudentsControl>().changedtosuit == true)
            {
                Debug.Log(32);

                seatmanmoved = true;
            }

            StartCoroutine(GetUp());
            StartCoroutine(MoveSeat());
            active = false;
        }
    }

    private IEnumerator GetUp()
    {
        yield return new WaitForSeconds(0.1f);


        Target.SetActive(false);

        ExchangedTarget1.SetActive(true);
    }

    private IEnumerator MoveSeat()
    {
        yield return new WaitForSeconds(1f);

        ExchangedTarget1.SetActive(false);


        ExchangedTarget2.SetActive(true);

    }

}