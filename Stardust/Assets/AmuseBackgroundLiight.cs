using UnityEngine;
using System.Collections;

public class AmuseBackgroundLiight : MonoBehaviour
{
    private float StarNumber = StarCollector.AmusementStar;
    public GameObject player;

    void Start()
    {
        GetComponent<Transform>().localScale = new Vector3(0f,0f,1f);
    }

	void Update ()
	{
	    StarNumber = StarCollector.AmusementStar;
        transform.position = new Vector3(player.transform.position.x,0f,18f);
        transform.localScale = new Vector3(StarNumber*1.5f,StarNumber*1.5f, 1f);
	}
}
