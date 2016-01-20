using UnityEngine;
using System.Collections;

public class ParticleCaller : MonoBehaviour {

	public string particleTag;
	public float Distance = 10;

	GameObject[] Particles;
	Vector3[] tempPos;
	Vector3[] temp;
	bool active = false;
	float smoothTime = 1f;

	private Vector3[] velocity;
	int routine = 0;
	
	void Start()
	{
		Particles = GameObject.FindGameObjectsWithTag (particleTag);
		tempPos = new Vector3[Particles.GetLength(0)];
		temp = new Vector3[Particles.GetLength (0)];
		velocity = new Vector3[Particles.GetLength (0)];

		for (int i = 0; i < Particles.GetLength (0); i++) 
		{
			tempPos[i] = Particles[i].transform.position;
			Particles [i].SetActive (false);
		}

	}

	void Update()
	{
		if (Input.GetMouseButton (0))//this part concerned with mouse following
		{
			Ray r = Camera.main.ScreenPointToRay (Input.mousePosition);//

			Vector3 tempPosition = r.GetPoint (Distance);
			transform.position = tempPosition;//transform.position is 'position of the transform in world space

			for (int i = 0; i < Particles.GetLength (0); i++) 
			{
				Particles [i].SetActive (true);

				tempPos[i] = Particles[i].transform.position;
			}
		}

		if(Input.GetMouseButtonUp(0))
		{
			if (active == true) 
			{
				routine = 1;
			}
			else 
			{
				routine = 2;
			}
			active = false;
		}
		if (routine == 1) 
		{
			
			foreach (GameObject particle in Particles)
			{
				particle.SetActive(false);
			}
			
		}

		if (routine == 2) 
		{
			PointerCall ();
		}

	}

	void PointerCall ()
	{
		for (int i = 0; i<Particles.GetLength(0); i++) 
		{
			Particles [i].SetActive (true);
			temp[i] = Vector3.SmoothDamp(Particles[i].transform.position, tempPos[i], ref velocity[i], smoothTime);
			Particles[i].transform.position = temp[i];
		}
	}

	void OnMouseDown()
	{
		active = true;
		for (int i = 0; i < Particles.GetLength(0); i++) {
			Particles [i].transform.position = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		}
	}
}
