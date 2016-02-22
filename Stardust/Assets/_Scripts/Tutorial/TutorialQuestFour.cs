using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TutorialQuestFour : MonoBehaviour
{
    public bool QuestFourOn;
    private int clickCount = 0;
    private GameObject Textbox;
    private GameObject Girl;
    public string[] QuestFourText;
    private GameObject[] paletteObjects;
    private GameObject popuptaxi;
    private GameObject popupgirl;

    private void Start()
    {
        Textbox = GameObject.FindGameObjectWithTag("Textbox_4");
        Girl = GameObject.FindGameObjectWithTag("Girl");
        popuptaxi = GameObject.FindGameObjectWithTag("PopupTaxi");
        popupgirl = GameObject.FindGameObjectWithTag("PopupGirl");

        popuptaxi.GetComponent<CanvasGroup>().alpha = 0;
        popupgirl.GetComponent<CanvasGroup>().alpha = 0;
    }


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject == Girl)
        {
            Girl.GetComponent<TutorialPlayerController>().Go = false;

            QuestFourOn = true;
            clickCount = 0;

            paletteObjects = GameObject.FindGameObjectsWithTag("PaletteObjects");

            foreach (GameObject item in paletteObjects)
            {
                item.GetComponentInChildren<Collider2D>().enabled = false;
            }
        }
    }


    private void Update()
    {
        if (Girl.GetComponent<TutorialPlayerController>().QuestCount == 3 && Input.GetMouseButtonDown(0))
        {
            clickCount += 1;
        }
        QuestGo();
    }

    private void QuestGo()
    {
        if (QuestFourOn == true)
        {
            if (clickCount == 0)
            {
                popuptaxi.GetComponent<CanvasGroup>().alpha = 1;
            }

            if (clickCount == 1)
            {

                popuptaxi.GetComponent<CanvasGroup>().alpha = 0;
                popupgirl.GetComponent<CanvasGroup>().alpha = 1;
            }

            if (clickCount == 2)
            {
                Textbox.GetComponent<CanvasGroup>().alpha = 1;

                popupgirl.GetComponent<CanvasGroup>().alpha = 0;
                Textbox.GetComponentInChildren<Text>().text = QuestFourText[0];
            }

            else if (clickCount == 3)
            {
                Textbox.GetComponentInChildren<Text>().text = QuestFourText[1];
            }

            else if (clickCount == 4)
            {
                Textbox.GetComponentInChildren<Text>().text = QuestFourText[2];

            }
            else if (clickCount == 5)
            {
                Textbox.GetComponent<CanvasGroup>().alpha = 0;
                foreach (GameObject item in paletteObjects)
                {
                    item.GetComponentInChildren<Collider2D>().enabled = true;
                }
            }
        }
    }
}