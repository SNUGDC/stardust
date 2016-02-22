using UnityEngine;
using System.Collections;

public class SmallLoopToBubble : MonoBehaviour
{

    public bool AnimEnd;
    public Collider2D SmallLoopCollider;
    public GameObject SmallBubble;

    void Update()
    {
        if (this.gameObject.activeInHierarchy)
        {
            Destroy(SmallLoopCollider);
            GetComponent<Animator>().SetBool("SmallBubble", true);

        }
    }

    void OnMouseDown()
    {
        if (AnimEnd)
        {
            Destroy(GetComponent<Collider2D>());
            Destroy(SmallBubble);
        }
    }
}
