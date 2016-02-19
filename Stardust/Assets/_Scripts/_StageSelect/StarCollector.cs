using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StarCollector : MonoBehaviour {

	public GameObject[] Stars;
	private static StarCollector star_instance;
	private int starCount;

	public static StarCollector Instance
	{
		get
		{
			return 	star_instance;
		}
	}

	private void Awake()
	{
		DontDestroyOnLoad(gameObject);
		star_instance = this;
	}

	private void OnDestroy()
	{
		star_instance = null;
	}

	void Update()
	{
		Stars = GameObject.FindGameObjectsWithTag ("Star") as GameObject[];
		starCount = Stars.GetLength (0);
		if (SceneManager.GetSceneByName("StageCave")) 
		{
			
		} else if (SceneManager.GetSceneByName ("StageForest")) {
			
		} else if (SceneManager.GetSceneByName ("StageMetro")) 
		{
			
		}

	}

}