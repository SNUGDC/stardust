using UnityEngine;
using System.Collections;

public class MetroTargetExchanger2 : MonoBehaviour {

    public GameObject Target1;
    public GameObject Target2;
    public GameObject ExchangedTarget1;
    public GameObject ExchangedTarget2;
    

    void Update()
    {
            StartCoroutine(Gundal());

        
    }

    IEnumerator Gundal()
    {
        yield return new WaitForSeconds(0.8f);

        Target1.SetActive(false);
        Target2.SetActive(false);

        ExchangedTarget1.SetActive(true);
        ExchangedTarget2.SetActive(true);
    }
}
