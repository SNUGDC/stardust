using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Diagnostics;

public class TutorialQuestTwo : MonoBehaviour
{

    private GameObject Girl;
    private int clickCount = 0;
    public string[] QuestTwoText;
    private GameObject Textbox;
    public bool QuestSolved;
    private GameObject arrow;
    private GameObject[] paletteObjects;

    private void Start()
    {
        Girl = GameObject.FindGameObjectWithTag("Girl");
        Textbox = GameObject.FindGameObjectWithTag("Textbox_2");
        QuestSolved = false;

        arrow = GameObject.FindGameObjectWithTag("HelpingArrow_2");
        arrow.GetComponent<CanvasGroup>().alpha = 0;

        paletteObjects = GameObject.FindGameObjectsWithTag("PaletteObjects");

        foreach (GameObject item in paletteObjects)
        {
            item.GetComponentInChildren<Collider2D>().enabled = false;
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == Girl)
        {
            Girl.GetComponent<TutorialPlayerController>().QuestCount = 1;
            Girl.GetComponent<TutorialPlayerController>().Go = false;
            Textbox.GetComponent<CanvasGroup>().alpha = 1;
            clickCount = 0;
            QuestSolved = false;
        }

    }


    private void Update()
    {
        if (Girl.GetComponent<TutorialPlayerController>().QuestCount == 1 && Input.GetMouseButtonDown(0))
        {
            clickCount += 1;
        }
        QuestGo();
    }

    private void QuestGo()
    {
        if (QuestSolved == false)
        {
            if (clickCount == 0)
            {
                Textbox.GetComponentInChildren<Text>().text = QuestTwoText[0];
            }

            else if (clickCount == 1)
            {
                Textbox.GetComponentInChildren<Text>().text = QuestTwoText[1];
            }

            else if (clickCount == 2)
            {
                Textbox.GetComponentInChildren<Text>().text = QuestTwoText[2];

            }
            else if (clickCount == 3)
            {
                Textbox.GetComponent<CanvasGroup>().alpha = 0;
                arrow.GetComponent<CanvasGroup>().alpha = 1;
                foreach (GameObject item in paletteObjects)
                {
                    item.GetComponentInChildren<Collider2D>().enabled = true;
                }
            }
        }
    }
}