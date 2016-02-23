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
	public GameObject[] AmusementArray;
	public GameObject[] ForestArray;
	public GameObject[] CaveArray;
	public GameObject[] AliceArray;

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
		for (int i = 0; i < 6; i++) {
			if (AmusementStar != i) {
				AmusementArray [i].SetActive (false);
			}
		}
		for (int i = 0; i < 4; i++) {
			if (CaveStar != i) {
				CaveArray [i].SetActive (false);
			}
		}
		for (int i = 0; i < 4; i++) 
		{
			if (AliceStar != i) {
				AliceArray [i].SetActive (false);
			}
		}
		for (int i = 0; i < 4; i++) {
			if (ForestStar != i) 
			{
				ForestArray [i].SetActive (false);
			}
		}
		AmusementArray [AmusementStar].SetActive (true);
		CaveArray [CaveStar].SetActive (true);
		AliceArray [AliceStar].SetActive (true);
		ForestArray [ForestStar].SetActive (true);
	}


}