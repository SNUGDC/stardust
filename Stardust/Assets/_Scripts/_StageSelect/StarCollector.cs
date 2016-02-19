using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StarCollector : MonoBehaviour {

	public static string SceneName;
	public static int CaveStar;
	public static int ForestStar;
	public static int MetroStar;
	public static int AliceStar;
	public static int AmusementStar;
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
		
	}


}