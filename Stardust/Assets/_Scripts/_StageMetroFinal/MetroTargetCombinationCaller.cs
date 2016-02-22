using UnityEngine;
using System.Collections;

public class MetroTargetCombinationCaller : MonoBehaviour
{

    public GameObject Target;
    public GameObject Target1;
    public GameObject Target2;
    public GameObject Target3;
    public GameObject Parent;
    public GameObject[] combiClass;// saving palettes in array include myself

    GameObject[] targetClass;

    string targetTag;
    //public int CombiCount = 0;

    void Start()
    {
        targetTag = Target.gameObject.tag;

    }


    void OnMouseDown()
    {

        foreach (GameObject target in targetClass) // all target of palette will be setActive(false)
        {
            target.SetActive(false);
        }

        Target.SetActive(true);//when we click button target of palette will be SetActive(true)

        if (combiClass[0].activeInHierarchy == true && combiClass[1].activeInHierarchy == true && combiClass[2].activeInHierarchy == true)
        {
            foreach (GameObject target in combiClass) // all target of palette will be setActive(false)
            {
                target.SetActive(false);
            }

            Target.SetActive(false);
            Target1.SetActive(true);
            Target2.SetActive(true);
            Target3.SetActive(false);
        }
        GetComponentInParent<PaletteCaller>().active = false;//Palette erase

    }


    void Update()
    {
        targetClass = GameObject.FindGameObjectsWithTag(targetTag);
        /*
        Debug.Log(10);
        if (combiClass[0].activeInHierarchy == true && combiClass[1].activeInHierarchy == true && combiClass[2].activeInHierarchy == true)
        {
            Debug.Log(11);
            Target1.SetActive(true); Target2.SetActive(true); Target3.SetActive(false);
            Parent.GetComponent<PaletteCaller>().enabled = false;
            Destroy(passenger.GetComponent<BoxCollider2D>());
            if (passenger.transform.position.y < wheretogo1.transform.position.y)
            {
                Debug.Log(12);
                passengermove = Vector3.MoveTowards(passenger.transform.position, wheretogo1.transform.position, speed * Time.deltaTime);
            }
            else
            {
                Debug.Log(13);
                passengermove = Vector3.MoveTowards(passenger.transform.position, wheretogo2.transform.position, speed * Time.deltaTime);
            }
        }*/

    }
}