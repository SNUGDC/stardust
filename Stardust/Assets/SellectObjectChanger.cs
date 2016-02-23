using UnityEngine;
using System.Collections;

public class SellectObjectChanger : MonoBehaviour {

    public GameObject[] AmusementArray;
    public GameObject[] ForestArray;
    public GameObject[] CaveArray;
    public GameObject[] AliceArray;

    public static string SceneName;
    public static int CaveStar;
    public static int ForestStar;
    public static int MetroStar;
    public static int AliceStar;
    public static int AmusementStar;

    void Start()
    {
        CaveStar = StarCollector.CaveStar;
        ForestStar = StarCollector.ForestStar;
        MetroStar = StarCollector.MetroStar;
        AliceStar = StarCollector.AliceStar;
        AmusementStar = StarCollector.AmusementStar;
    }

    void Update()
    {
        for (int i = 0; i < 6; i++)
        {
            if (AmusementStar != i)
            {
                AmusementArray[i].SetActive(false);
            }
        }
        for (int i = 0; i < 4; i++)
        {
            if (CaveStar != i)
            {
                CaveArray[i].SetActive(false);
            }
        }
        for (int i = 0; i < 4; i++)
        {
            if (AliceStar != i)
            {
                AliceArray[i].SetActive(false);
            }
        }
        for (int i = 0; i < 4; i++)
        {
            if (ForestStar != i)
            {
                ForestArray[i].SetActive(false);
            }
        }
        AmusementArray[AmusementStar].SetActive(true);
        CaveArray[CaveStar].SetActive(true);
        AliceArray[AliceStar].SetActive(true);
        ForestArray[ForestStar].SetActive(true);
    }
}
