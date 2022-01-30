using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Camera cam;
    Color white = Color.white;
    Color black = Color.black;
    SpriteRenderer sr;
    [SerializeField] private float dmg = 1f;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (cam.backgroundColor == black)
            sr.color = white;
        else
            sr.color = black;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy") {
            other.gameObject.GetComponent<Enemy>().UpdateHealth(-dmg);
            ScoreCounter.score += 1;
        }
        Destroy(gameObject);
        // if (collision.gameObject.tag == "Obstacle")
    }
}
