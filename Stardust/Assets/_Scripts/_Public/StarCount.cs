using UnityEngine;
using System.Collections;

public class StarCount : MonoBehaviour {

	public string SceneName;
	// Use this for initialization
	void Start () {
		if (SceneName == "CaveStar") 
		{
			StarCollector.CaveStar += 1;
		}
		else if (SceneName == "MetroStar") 
		{
			StarCollector.MetroStar += 1;
		}
		else if (SceneName == "ForestStar") 
		{
			StarCollector.ForestStar += 1;
		}
		else if (SceneName == "AmusementStar") 
		{
			StarCollector.AmusementStar += 1;
		}
		else if (SceneName == "AliceStar") 
		{
			StarCollector.AliceStar += 1;
		}
		Debug.Log ("CaveStar:" + StarCollector.CaveStar);
		Debug.Log ("MetroStar:" + StarCollector.MetroStar);
		Debug.Log ("ForestStar:" + StarCollector.ForestStar);
		Debug.Log ("AmusementStar:" + StarCollector.AmusementStar);
		Debug.Log ("AliceStar:" + StarCollector.AliceStar);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
