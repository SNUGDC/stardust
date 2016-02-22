using UnityEngine;
using System.Collections;

public class TutorialCrosswalk : MonoBehaviour {

    private GameObject Girl;
    private GameObject QuestThree;
    private GameObject QuestFour;
    private GameObject crosswalk;

    void Start()
    {
        Girl = GameObject.FindGameObjectWithTag("Girl");
        QuestThree = GameObject.FindGameObjectWithTag("Quest_3");
        QuestFour = GameObject.FindGameObjectWithTag("Quest_4");
        crosswalk = GameObject.FindGameObjectWithTag("Crosswalk");

        QuestFour.GetComponent<BoxCollider2D>().enabled = false;

    }

    private void OnMouseDown()
    {
        if (Girl.GetComponent<TutorialPlayerController>().QuestCount == 2)
        {
            QuestFour.GetComponent<BoxCollider2D>().enabled = true;
            QuestThree.GetComponent<TutorialQuestThree>().QuestThreeOn = false;
            Girl.GetComponent<TutorialPlayerController>().QuestCount++;
            Destroy(QuestThree);
            Destroy(crosswalk);
        }
    }

}
