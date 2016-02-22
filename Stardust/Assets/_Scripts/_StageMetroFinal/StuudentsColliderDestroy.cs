using UnityEngine;
using System.Collections;

public class StuudentsColliderDestroy : MonoBehaviour
{


    public GameObject suit;

    void Start()
    {

    }

    void Update()
    {
        if (suit.GetComponent<MetroStudentsControl>().changedtosuit == true)
        {
            Destroy(this.gameObject);
        }
    }
}