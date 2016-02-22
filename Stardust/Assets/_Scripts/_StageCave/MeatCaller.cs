using UnityEngine;
using System.Collections;

public class MeatCaller : MonoBehaviour
{

    public GameObject Player;
    public GameObject Meat;
    public GameObject Bone;
    public GameObject BearCave;
    public GameObject BearShadow;

    void OnMouseDown()
    {
        if (GetComponentInParent<TorchControl>().torchGet == true && Player.transform.position.x >= 40.7f &&
            Player.transform.position.x <= 41f)
        {
            Bone.SetActive(false);
            BearShadow.SetActive(false);
            Destroy(BearCave.GetComponent<Collider2D>());
            Meat.GetComponent<Animator>().SetBool("bearmoving",true);
        }
    }

}
