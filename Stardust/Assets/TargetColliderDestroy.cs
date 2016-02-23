using UnityEngine;
using System.Collections;

public class TargetColliderDestroy : MonoBehaviour
{

    public Collider2D TargetCollider2D;

	void Start () {
        TargetCollider2D.enabled = false;
	}
}
