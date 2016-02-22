using UnityEngine;
using System.Collections;

public class SpriteTransition : MonoBehaviour {
    // Sprites transition into CROSSFADE
    // Use this for initialization
    public bool Transition_Active = false;
    public GameObject Target_ToBeChanged;
    public GameObject Target_ToChange;
    public int FadingTime;
    Color Fade;

	void Start () {
        Fade = new Color(1, 1, 1, 0);
	}
	
	// Update is called once per frame
	void Update () {
        if(Transition_Active == true)
        {
            
            Color.Lerp(Target_ToBeChanged.GetComponent<SpriteRenderer>().color, Fade, Time.deltaTime * FadingTime);
            Color.Lerp(Target_ToChange.GetComponent<SpriteRenderer>().color, Fade, Time.deltaTime * FadingTime);
        }
	
	}
}
