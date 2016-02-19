using UnityEngine;
using System.Collections;

public class SkyCaller : MonoBehaviour {

	public GameObject Target;

	GameObject[] targetClass;


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

		Target.GetComponent<PositionSet> ().MovePlanet ();
		this.gameObject.SetActive(false);
	}


}


