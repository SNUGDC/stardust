using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TutorialTraffic : MonoBehaviour
{

    private GameObject Girl;
    private GameObject QuestThree;
    private GameObject QuestTwo;
    private GameObject traffic;
    private GameObject arrow;


    void Start ()
    {
	    Girl=GameObject.FindGameObjectWithTag("Girl");
	    QuestThree = GameObject.FindGameObjectWithTag("Quest_3");
	    QuestTwo = GameObject.FindGameObjectWithTag("Quest_2");
        traffic = GameObject.FindGameObjectWithTag("Traffic");
        arrow = GameObject.FindGameObjectWithTag("HelpingArrow_2");

        QuestThree.GetComponent<BoxCollider2D>().enabled = false;

    }

    private void OnMouseDown()
    {
        if (Girl.GetComponent<TutorialPlayerController>().QuestCount == 1)
        {
            QuestThree.GetComponent<BoxCollider2D>().enabled = true;
            QuestTwo.GetComponent<TutorialQuestTwo>().QuestSolved = true;
            Girl.GetComponent<TutorialPlayerController>().QuestCount++;
            Destroy(QuestTwo);
            Destroy(traffic);
            Destroy(arrow);
        }
    }
}
