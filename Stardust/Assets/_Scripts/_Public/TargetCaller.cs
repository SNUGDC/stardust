using UnityEngine;
using System.Collections;

public class TargetCaller : MonoBehaviour {

	public GameObject Target;
    //public Animator HatturningAni;

	GameObject [] targetClass;

	  
	string targetTag;

	//string combiTag;

	void Start()
	{
		targetTag = Target.gameObject.tag;

	}

	void Update()
	{
		targetClass = GameObject.FindGameObjectsWithTag (targetTag);
	}


	void OnMouseDown()
	{
		
		foreach (GameObject target in targetClass) // all target of palette will be setActive(false)
		{
			target.SetActive (false);
		}

		Target.SetActive (true);//when we click button target of palette will be SetActive(true)
//        HatturningAni.SetBool("Hathold", true);
	}


}


