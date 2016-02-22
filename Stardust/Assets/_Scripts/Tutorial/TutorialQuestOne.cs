using UnityEngine;
using System.Collections;
using JetBrains.Annotations;
using UnityEngine.UI;

public class TutorialQuestOne : MonoBehaviour
{

    private GameObject Textbox;
    private bool QuestSolved;
    private GameObject Girl;
    public string[] QuestOneText;
    private int clickCount;
    private GameObject[] arrows;

    private void Start()
    {

        Textbox = GameObject.FindGameObjectWithTag("Textbox_1");
        Girl = GameObject.FindGameObjectWithTag("Girl");

        clickCount = 0;
        Textbox.GetComponent<CanvasGroup>().alpha = 0;
        //Girl.GetComponent<PlayerController>().Go = false;

        arrows = GameObject.FindGameObjectsWithTag("HelpingArrow_1");
        foreach (GameObject item in arrows)
        {
            item.GetComponentInChildren<CanvasGroup>().alpha = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == Girl)
        {
            QuestSolved = false;
        }
    }


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickCount += 1;
        }
        QuestGo();
    }

    private void QuestGo()
    {
        if (QuestSolved == false)
        {

            if (clickCount == 1)
            {
                Textbox.GetComponent<CanvasGroup>().alpha = 1;

                Textbox.GetComponentInChildren<Text>().text = QuestOneText[0];
            }

            else if (clickCount == 2)
            {
                Textbox.GetComponentInChildren<Text>().text = QuestOneText[1];
            }

            else if (clickCount == 3)
            {
                Textbox.GetComponentInChildren<Text>().text = QuestOneText[2];

            }
            else if (clickCount == 4)
            {
                Textbox.GetComponent<CanvasGroup>().alpha = 0;
                foreach (GameObject item in arrows)
                {
                    item.GetComponentInChildren<CanvasGroup>().alpha = 1;
                }

            }
            else if (clickCount >= 5)
            {
                QuestSolved = true;
                Girl.GetComponent<TutorialPlayerController>().Go = true;
                Destroy(Textbox);
                Destroy(gameObject);
                foreach (GameObject item in arrows)
                {
                    Destroy(item);
                }
                clickCount = 0;
            }
        }
    }
}
