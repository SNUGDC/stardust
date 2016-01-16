using UnityEngine;
using System.Collections;

public class ParticleCaller : MonoBehaviour {
	
	public float Distance = 10;

	
	void Update()
	{
		if (Input.GetMouseButton (0)) 
		{
			Ray r = Camera.main.ScreenPointToRay (Input.mousePosition);//
			
			Vector3 tempPosition = r.GetPoint (Distance);//tempPosition represents '
			transform.position = tempPosition;//transform.position is 'position of the transform in world space
		}
		/*
		if (Input.GetMouseButtonUp (0)) 
		{
			IEnumerator 
		}
		*/
	}
}