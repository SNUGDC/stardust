using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TutorialQuestThree : MonoBehaviour
{

    public bool QuestThreeOn;
    private int clickCount = 0;
    private GameObject Textbox;
    private GameObject Girl;
    public string[] QuestThreeText;
    private GameObject[] paletteObjects;

    private void Start()
    {
        Textbox = GameObject.FindGameObjectWithTag("Textbox_3");
        Girl = GameObject.FindGameObjectWithTag("Girl");
    }


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject == Girl)
        {
            Girl.GetComponent<TutorialPlayerController>().Go = false;
            Textbox.GetComponent<CanvasGroup>().alpha = 1;

            QuestThreeOn = true;
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
        if (Girl.GetComponent<TutorialPlayerController>().QuestCount == 2 && Input.GetMouseButtonDown(0))
        {
            clickCount += 1;
            
        }
        QuestGo();
    }

    private void QuestGo()
    {
        if (QuestThreeOn == true)
        {
            if (clickCount == 0)
            {
                Textbox.GetComponentInChildren<Text>().text = QuestThreeText[0];
            }

            else if (clickCount == 1)
            {
                Textbox.GetComponentInChildren<Text>().text = QuestThreeText[1];
            }

            else if (clickCount == 2)
            {
                Textbox.GetComponentInChildren<Text>().text = QuestThreeText[2];

            }
            else if (clickCount == 3)
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
