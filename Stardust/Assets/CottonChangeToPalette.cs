using UnityEngine;
using System.Collections;

public class CottonChangeToPalette : MonoBehaviour
{
    public GameObject TargetPalette;
    public GameObject White;

    private Vector3 Velocity = Vector3.zero;
    public float Smooth = 0.3f;

    private bool Active = false;

    void Start()
    {
        TargetPalette.GetComponent<Collider2D>().enabled = false;
        TargetPalette.GetComponent<SpriteRenderer>().enabled = false;
    }

    void Update()
    {
        if (Active)
        {
            transform.position = Vector3.SmoothDamp(transform.position, TargetPalette.transform.position, ref Velocity,
                Smooth);
        }
    }

    private void OnMouseDown()
    {
        TargetPalette.GetComponent<Collider2D>().enabled = true;
        TargetPalette.GetComponent<SpriteRenderer>().enabled = true;
        Active = true;
        White.SetActive(true);
        StartCoroutine(DestroyThis());
    }

    IEnumerator DestroyThis()
    {
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
    }
}
