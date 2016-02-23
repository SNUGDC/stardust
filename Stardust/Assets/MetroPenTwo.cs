using UnityEngine;
using System.Collections;

public class MetroPenTwo : MonoBehaviour
{

    // Use this for initialization
    public GameObject girl;
    public GameObject player;


    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        if (girl.GetComponent<MetroSeatGirlMoveControl>().seatgirlgone)
        {
            if (player.transform.position.x < transform.position.x + 0.5 &&
                player.transform.position.x > transform.position.x - 0.5)
            {
                Destroy(this.gameObject);
            }


        }
    }
}
