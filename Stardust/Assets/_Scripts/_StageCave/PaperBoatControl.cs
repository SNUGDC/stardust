using UnityEngine;
using System.Collections;

public class PaperBoatControl : MonoBehaviour {

	private bool active;
    public bool paletteActive;
	public GameObject Pond;
//    public string PaperPaletteTag;
    public GameObject[] PaperPalettes;
    public GameObject[] Papers;
    public GameObject Boat;
    public GameObject PaperPalette;

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
            if(active == false && paletteActive == false)
			{
			    foreach (GameObject palette in PaperPalettes)
			    {
			        palette.SetActive(false);
                    palette.GetComponent<TargetCaller>().Target.SetActive(false);
			    }
				this.gameObject.SetActive (false);
            }
		    if (active == false && paletteActive == true)
		    {
                foreach (GameObject palette in PaperPalettes)
                {
                    palette.SetActive(false);
                }
            }
			active = false;
		    paletteActive = false;
		}

	    if (Papers[0].activeInHierarchy == true && Papers[3].activeInHierarchy == true)
	    {
	        Boat.SetActive(true);
	        Pond.GetComponent<PolygonCollider2D>().enabled = false;
            Destroy(PaperPalette);
            this.gameObject.SetActive(false);
	    }
        else if (Papers[1].activeInHierarchy == true && Papers[4].activeInHierarchy == true)
        {
            Boat.SetActive(true);
            Pond.GetComponent<PolygonCollider2D>().enabled = false;
            Destroy(PaperPalette);
            this.gameObject.SetActive(false);
        }

    }

    void OnMouseDown()
    {
		active = true;
	    Pond.GetComponent<touchedTargetCaller>().targetActive = true;
	}
}
