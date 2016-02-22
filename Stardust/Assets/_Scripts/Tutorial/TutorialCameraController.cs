using UnityEngine;
using System.Collections;

public class TutorialCameraController : MonoBehaviour
{
    public GameObject Girl;
    public float LeftEdge;
    public float RightEdge;

    private float GirlStopXPosition;
    private float GirlXPosition;
    private float YOffset;

    const float XOffset = 0;
    const float ZOffset = -10;

    

    void LateUpdate()
    {
        YOffset = -Girl.GetComponent<Transform>().position.y;
        GirlXPosition = Girl.GetComponent<Transform>().position.x;

        if (GirlXPosition > LeftEdge && GirlXPosition < RightEdge)
        {
            transform.position = new Vector3(Girl.transform.position.x + XOffset,
                                                  Girl.transform.position.y + YOffset,
                                                  Girl.transform.position.z + ZOffset);
        }

        else if(GirlXPosition>RightEdge || GirlXPosition < LeftEdge)
        {
            GirlStopXPosition = transform.position.x;
            transform.position=new Vector3(GirlStopXPosition, 
                Girl.transform.position.y + YOffset, 
                Girl.transform.position.z + ZOffset);
        }
    }
}