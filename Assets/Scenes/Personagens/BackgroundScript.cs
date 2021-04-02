using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    private float screenWidth;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D body = GetComponent<Rigidbody2D>();
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
    
        float imageWidth = renderer.sprite.bounds.size.x;
        float imageHeight = renderer.sprite.bounds.size.x;

        float screenHeight = Camera.main.orthographicSize * 4;
        screenWidth = screenHeight / Screen.height * Screen.width;

        Vector2 newScale = this.transform.localScale;
        newScale.x = screenWidth / imageWidth + 1f;
        newScale.y = screenHeight / imageHeight;
        this.transform.localScale = newScale;

        body.velocity = new Vector2(-5,0);

         if (this.name == "Background2"){
            this.transform.position = new Vector2(screenWidth, 0);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.x <= -screenWidth){
            this.transform.position = new Vector2(screenWidth, 0);
        }
    }
}
