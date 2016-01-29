using UnityEngine;
using System.Collections;

public class GundalCollider : MonoBehaviour {

    public GameObject Collidercontroll;

    void Start()
    {
        Collidercontroll.GetComponent<ColliderControll>().Condition = true;
    }
}
