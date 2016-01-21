using UnityEngine;
using System.Collections;

public class ObjectCollector : MonoBehaviour {

    public GameObject Girl;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Girl")
        {
            StartCoroutine(Collect());
        }
    }
    IEnumerator Collect()
    {
        Girl.GetComponent<GirlController>().Go = false;
        Girl.GetComponent<Animator>().SetTrigger("GirlStop");
        yield return new WaitForSeconds(0.5f);
        Destroy(GetComponent<SpriteRenderer>());
        yield return new WaitForSeconds(0.5f);
        Girl.GetComponent<GirlController>().Go = true;
        Girl.GetComponent<Animator>().SetTrigger("Girl");
    }
}
