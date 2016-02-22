using UnityEngine;
using System.Collections;

public class SmallLoopToBubble : MonoBehaviour {

    void Update()
    {
        if (this.gameObject.activeInHierarchy)
        {
            Destroy(GetComponentInParent<CircleCollider2D>());
            GetComponent<Animator>().SetBool("BigBubble", true);

        }
    }
}
