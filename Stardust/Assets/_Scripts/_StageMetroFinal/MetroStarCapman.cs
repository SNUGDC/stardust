using UnityEngine;
using System.Collections;

public class MetroStarCapman : MonoBehaviour
{

    public GameObject wheretogo;
    Vector3 vel;
    float smoothtime;

    void Start()
    {
        vel = new Vector3();
        smoothtime = 0.5f;
    }

    void Update()
    {
        Debug.Log(2);
        Vector3 temp = Vector3.SmoothDamp(this.gameObject.transform.position, wheretogo.transform.position, ref vel, smoothtime);
        this.gameObject.transform.position = temp;
        Debug.Log(3);

    }
}
