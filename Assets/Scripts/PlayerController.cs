using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    public Rigidbody2D rb;
    public Camera cam;

    Vector2 movement;
    Vector2 mousePos;
    Color white = Color.white;
    Color black = Color.black;
    SpriteRenderer sr = null;

    void Start() 
    {
        cam = Camera.main;
        sr = gameObject.GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        PlayerColor();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y ,lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }

    void PlayerColor()
    {
        if (cam.backgroundColor == black)
            sr.color = white;
        else
            sr.color = black;
    }
}
