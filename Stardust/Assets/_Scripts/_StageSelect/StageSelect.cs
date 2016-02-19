using UnityEngine;
using System.Collections;

public class StageSelect : MonoBehaviour {

	public int level;

	void OnMouseDown()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene (level);
	}
}

