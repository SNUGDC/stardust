using UnityEngine;
using System.Collections;

public class TutorialButtonContainer : MonoBehaviour
{
    public bool isEnabled;

    private GameObject[] buttons;

    void OnMouseClick()
    {
        isEnabled = !isEnabled;
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(isEnabled);
        }
    }
}
