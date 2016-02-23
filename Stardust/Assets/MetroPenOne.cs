using UnityEngine;
using System.Collections;

public class MetroPenOne : MonoBehaviour
{

    public GameObject man;
    public GameObject player;

    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        if (man.GetComponent<MetroTargetExchanger>().seatmanmoved)
        {
            if (player.transform.position.x < transform.position.x + 0.5 &&
                player.transform.position.x > transform.position.x - 0.5)
            {
                Destroy(this.gameObject);
            }

        }
    }
}