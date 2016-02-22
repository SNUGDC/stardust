using UnityEngine;
using System.Collections;

public class TutorialTaxi : MonoBehaviour
{

    private GameObject Girl;
    private GameObject QuestFour;
    private GameObject taxi;

    void Start()
    {
        Girl = GameObject.FindGameObjectWithTag("Girl");
        QuestFour = GameObject.FindGameObjectWithTag("Quest_4");
        taxi = GameObject.FindGameObjectWithTag("Taxi");

        QuestFour.GetComponent<BoxCollider2D>().enabled = false;

    }

    private void OnMouseDown()
    {
        if (Girl.GetComponent<TutorialPlayerController>().QuestCount == 3)
        {
            QuestFour.GetComponent<TutorialQuestFour>().QuestFourOn = false;
            Destroy(QuestFour);
            Destroy(taxi.GetComponent<BoxCollider2D>());
            //택시 타고 떠나는 애니메이션 들어갈 부분
        }
    }

}
