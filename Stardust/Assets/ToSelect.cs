using UnityEngine;
using System.Collections;

public class ToSelect : MonoBehaviour {
    public GameObject GotoSelect;
    public int level;
    // Use this for initialization
    IEnumerator Start () {
        yield return new WaitForSeconds(3);
    }
	
	// Update is called once per frame
	void Update () {
        if (GotoSelect.activeInHierarchy == false)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(level);
        }
    }
}

