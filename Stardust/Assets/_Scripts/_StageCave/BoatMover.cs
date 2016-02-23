using UnityEngine;
using System.Collections;

public class BoatMover : MonoBehaviour
{
    public GameObject Player;
    public Collider2D LeftCollider;
    public Collider2D RightCollider;
    public GameObject BoatFront;
    public GameObject Torch;

    private bool OnBoard = false;
    private bool goright = false;
    private bool goleft = false;

    void FixedUpdate()
    {
        if (LeftCollider.IsTouching(Player.GetComponent<Collider2D>()))
        {
            OnBoard = true;
            StartCoroutine(goRight());
            goright = true;
        }
        if (goright)
        {
            transform.Translate(2*Time.deltaTime,0,0);
            Torch.transform.position = new Vector3(transform.position.x + 0.8f, transform.position.y+0.5f, 0);
        }
        if (RightCollider.IsTouching(Player.GetComponent<Collider2D>()))
        {
            OnBoard = true;
            StartCoroutine(goLeft());
            goleft = true;
        }
        if (goleft)
        {
            transform.Translate(-2 * Time.deltaTime, 0, 0);
            Torch.transform.position = new Vector3(transform.position.x - 0.8f, transform.position.y + 0.5f, 0);
        }

        if (OnBoard)
        {
            Player.transform.position = new Vector3(transform.position.x,transform.position.y+0.5f,transform.position.z);
        }
    }

    IEnumerator goRight()
    {
        BoatFront.GetComponent<Renderer>().sortingOrder = 3;
        Player.GetComponent<PlayerController>().enabled = false;
        Player.GetComponent<Animator>().enabled = false;
        Torch.GetComponent<TorchControl>().enabled = false;
        Player.GetComponent<Rigidbody2D>().isKinematic = true;
        yield return new WaitForSeconds(3);
        Player.GetComponent<Rigidbody2D>().isKinematic = false;
        Torch.GetComponent<TorchControl>().enabled = true;
        Player.GetComponent<Animator>().enabled = true;
        Player.GetComponent<PlayerController>().enabled = true;
        OnBoard = false;
        goright = false;
        BoatFront.GetComponent<Renderer>().sortingOrder = 0;
        Player.transform.position = new Vector3(transform.position.x+5,Player.transform.position.y+1,Player.transform.position.z);
    }

    IEnumerator goLeft()
    {
        BoatFront.GetComponent<Renderer>().sortingOrder = 3;
        Player.GetComponent<PlayerController>().enabled = false;
        Player.GetComponent<Animator>().enabled = false;
        Torch.GetComponent<TorchControl>().enabled = false;
        Player.GetComponent<Rigidbody2D>().isKinematic = true;
        yield return new WaitForSeconds(3);
        Player.GetComponent<Rigidbody2D>().isKinematic = false;
        Torch.GetComponent<TorchControl>().enabled = true;
        Player.GetComponent<Animator>().enabled = true;
        Player.GetComponent<PlayerController>().enabled = true;
        OnBoard = false;
        goleft = false;
        BoatFront.GetComponent<Renderer>().sortingOrder = 0;
        Player.transform.position = new Vector3(transform.position.x - 5, Player.transform.position.y + 1, Player.transform.position.z);
    }
}
