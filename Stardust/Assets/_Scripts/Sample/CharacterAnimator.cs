using UnityEngine;
using System.Collections;

public class CharacterAnimator : MonoBehaviour
{

    public Sprite[] sprites;
    public float framesPerSec;
    public float multiplyframes;
    float clickposX = 0;
    bool facingRight = true;


    private SpriteRenderer spriterenderer;

    void Start()
    {
        spriterenderer = GetComponent<Renderer>() as SpriteRenderer;
    }

    void Update()
    {
        float playerposX = transform.localPosition.x;
        if (Input.GetMouseButton(0))
        {
            clickposX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
            framesPerSec = Mathf.Abs(clickposX - playerposX) / multiplyframes;
            OngoingSprites();
        }
        if (playerposX > clickposX)
        {
            if (facingRight == true)
            {
                Flip();
            }
            
        }
        if (playerposX < clickposX)
        {
            if (facingRight == false)
            {
                Flip();
            }
            
        }
    }


    void WalkingSystem()
    {

    }

    void StartingSprites()
    {

    }
    
    void OngoingSprites()
    {
        int index = (int)(Time.timeSinceLevelLoad * framesPerSec);
        index = index % sprites.Length;
        spriterenderer.sprite = sprites[index];
    }
        
    void EndingSprites()
    {

    }
    
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x = -theScale.x;
        transform.localScale = theScale;
    }
}