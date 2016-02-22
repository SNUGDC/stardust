using UnityEngine;
using System.Collections;

public class TargetColliderDestroy : MonoBehaviour
{

    public Collider2D TargetCollider2D;

	void Start () {
	    Destroy(TargetCollider2D);
	}
}
