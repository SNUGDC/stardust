using UnityEngine;
using System.Collections;

public class HatBehavior : MonoBehaviour {

    public GameObject Player;
	public bool HatActive = false;
	void Update () {
        if(HatActive == true)
        {	
			this.GetComponent<Animator> ().enabled = false;
            transform.parent = Player.transform;
//			float PlayerPositionX = Player.transform.position.x;
//			float PlayerPositionY = Player.transform.position.y;
//            this.transform.localPosition = new Vector3(PlayerPositionX, PlayerPositionY + 1.4f, 0);
			this.transform.localPosition = new Vector3(0, 1.4f, 0);
        }
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            HatActive = true;
        }
    }
}
