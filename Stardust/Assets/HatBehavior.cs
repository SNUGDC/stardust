using UnityEngine;
using System.Collections;

public class HatBehavior : MonoBehaviour {

    public GameObject Player;
    public bool HatActive = false;
    Vector2 temp;
	//동방에 형들 오면 물어봐야겠습니다 ㅠ 왜 모자가 아래에서 따라오는지 도저히 모르겠어요.
	void Update () {
        if(HatActive == true)
        {
            transform.parent = Player.transform;
            float PlayerpositionX = Player.transform.position.x;
            float PlayerpositionY = Player.transform.position.y;
            transform.position = new Vector3(PlayerpositionX, PlayerpositionY + 1.4f);
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
