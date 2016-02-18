using UnityEngine;
using System.Collections;

public class TargetEnabledFalse : MonoBehaviour {


	public GameObject Mine;
	public PaletteCaller Target;
	GameObject[] targetClass;

	string targetTag;

	void Update()
	{
		
		//targetTag = Target.gameObject.tag;
		Target.GetComponent<PaletteCaller> ().enabled = false;
		this.GetComponent<TargetEnabledFalse> ().enabled = false;

	}
}