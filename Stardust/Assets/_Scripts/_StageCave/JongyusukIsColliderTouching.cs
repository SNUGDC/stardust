using UnityEngine;
using System.Collections;

public class JongyusukIsColliderTouching : MonoBehaviour
{
    public GameObject Player;

	void Update () {

	    if (GetComponent<Collider2D>().IsTouching(Player.GetComponent<Collider2D>()))
	    {
	        GetComponent<touchedPaletteCaller>().mushroomState = touchedPaletteCaller.eState.Contact;
	    }
	}
}
