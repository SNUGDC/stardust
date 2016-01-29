using UnityEngine;
using System.Collections;

public class StageSelect : MonoBehaviour {

	public void LoadScene(int level)
	{
		Application.LoadLevel(level);
	} 
}
