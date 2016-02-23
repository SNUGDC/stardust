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
	        
	        Pond.GetComponent<PolygonCollider2D>().enabled = false;
            Pond.GetComponent<BoxCollider2D>().enabled = false;
            
            StartCoroutine(Wait());
	    }
        else if (Papers[1].activeInHierarchy == true && Papers[4].activeInHierarchy == true)
        {
            
            Pond.GetComponent<PolygonCollider2D>().enabled = false;
            Pond.GetComponent<BoxCollider2D>().enabled = false;
            
            StartCoroutine(Wait());
        }

    }

    void OnMouseDown()
    {
		active = true;
	    Pond.GetComponent<touchedTargetCaller>().targetActive = true;
	}

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.2f);
        PaperPalette.SetActive(false);
        yield return new WaitForSeconds(1f);
        gameObject.SetActive(false);
        Boat.SetActive(true);
    }
}
