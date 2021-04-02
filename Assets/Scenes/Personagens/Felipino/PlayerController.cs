using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 6.0f;
    SpriteRenderer sr;

    Rigidbody2D rb;
    public float forca = 5;


    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.position += new Vector3(6 * speed * Time.deltaTime, 0, 0);
            sr.flipX = false;
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.position -= new Vector3(6 * speed * Time.deltaTime, 0, 0);
            sr.flipX = true;
        }
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            rb.AddForce(transform.up* forca);
        }
    }
}
