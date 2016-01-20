using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public float minCamPos;
    public float maxCamPos;

    Vector3 prevPosition;
    Vector3 deltaPosition;

    void Update()
    {
        

        if (Input.GetMouseButton(0))
        {
            if (prevPosition == Vector3.zero)
            {
                prevPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
            else
            {
                deltaPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - prevPosition;
                Camera.main.transform.Translate(-deltaPosition.x, 0, 0);
                prevPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                transform.position = new Vector3(Mathf.Clamp(transform.position.x, minCamPos, maxCamPos), 0, transform.position.z);
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            prevPosition = Vector3.zero;
        }
    }
}
