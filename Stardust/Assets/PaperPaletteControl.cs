using UnityEngine;
using System.Collections;

public class PaperPaletteControl : MonoBehaviour
{

    public GameObject Paper;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        Paper.GetComponent<PaperBoatControl>().paletteActive = true;
    }
}
