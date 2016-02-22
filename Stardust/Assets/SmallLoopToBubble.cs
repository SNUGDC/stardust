using UnityEngine;
using System.Collections;

public class SmallLoopToBubble : MonoBehaviour
{

    public bool AnimEnd;
    public Collider2D SmallLoopCollider;
    public GameObject SmallBubble;
    public GameObject star;

    void Update()
    {
        if (this.gameObject.activeInHierarchy)
        {
            Destroy(SmallLoopCollider);
            GetComponent<Animator>().SetBool("SmallBubble", true);

        }
            star.transform.position = new Vector3(SmallBubble.transform.position.x, SmallBubble.transform.position.y, 0f);
    }

    void OnMouseDown()
    {
        if (AnimEnd)
        {
            Destroy(GetComponent<Collider2D>());
            SmallBubble.SetActive(false);
            star.GetComponent<StarCount>().enabled = true;
        }
    }
}
