using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TutorialButtonTouch : MonoBehaviour
{


    public bool QuestSolved = false;
    public string[] Quest_1;
    public string[] Quest_2;
    public string[] Quest_3;


    private GameObject[] PaletteObjects;
    private GameObject Girl;
    public Text Textbox_1;
    private GameObject Panel;
//    private bool ShowText = false;
//    private bool GirlMove = false;

	void Start ()
	{
	    Girl = GameObject.FindGameObjectWithTag("Girl");
	    Panel = GameObject.FindGameObjectWithTag("Panel");

	    GirlMove = Girl.GetComponent<TutorialPlayerController>().Go;

        Textbox_1.text = "";
        Panel.GetComponent<CanvasGroup>().alpha = 0;
        
        GetComponent<CanvasGroup>().alpha = 0;

        PaletteObjects = GameObject.FindGameObjectsWithTag("PaletteObjects");

        foreach (GameObject item in PaletteObjects)
        {
            item.GetComponent<Collider2D>().enabled=false;
        }
	}

    void OnMouseDown ()
    {
        
    }

    void OnMouseUp()
    {
        foreach (GameObject item in PaletteObjects)
        {
            item.GetComponent<Collider2D>().enabled=true;
        }
        QuestSolved = true;
    }

    void OnTriggerEnter()
    {
        ShowText = true;
    }
}
