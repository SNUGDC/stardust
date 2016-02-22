using UnityEngine;
using System.Collections;

public class TutorialTargetCaller : MonoBehaviour
{


    public GameObject Target;

    private GameObject[] targetClass;
    private GameObject Girl;

    private string targetTag;

    private void Start()
    {
        Girl = GameObject.FindGameObjectWithTag("Girl");
        targetTag = Target.gameObject.tag;
        //targetClass = GameObject.FindGameObjectsWithTag (targetTag);
    }

    private void Update()
    {
        targetClass = GameObject.FindGameObjectsWithTag(targetTag);
    }

    private void OnMouseDown()
    {
        foreach (GameObject target in targetClass)
        {
            target.SetActive(false);
        }
        Target.SetActive(true);
        GetComponentInParent<TutorialPaletteCaller>().active = false; //Palette erase

        Girl.GetComponent<TutorialPlayerController>().Go = true;

    }

}






