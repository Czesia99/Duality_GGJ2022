using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageDimension : MonoBehaviour
{
    Color[] dimensions = new Color[] {Color.white, Color.black};
    [Dropdown("dimensions")]
    public Color dimension;
    public Camera cam;
    private SpriteRenderer sr;
    CircleCollider2D cir = null;
    PolygonCollider2D pol = null;

    BoxCollider2D box = null;
    // SpriteRenderer sr;
    Color objectColor;


    // Update is called once per frame
    void Start() 
    {
        cam = Camera.main;
        sr = gameObject.GetComponent<SpriteRenderer>();
        if (gameObject.GetComponent<CircleCollider2D>() != null) {
            cir = gameObject.GetComponent<CircleCollider2D>();
        }
        if (gameObject.GetComponent<PolygonCollider2D>() != null) {
            pol = gameObject.GetComponent<PolygonCollider2D>();
        }
        if (gameObject.GetComponent<BoxCollider2D>() != null) {
            box = gameObject.GetComponent<BoxCollider2D>();
        }
        // if (dimension == "white")
        //     objectColor = Color.white;
        // else
        //     objectColor = Color.black;
    }
    void Update()
    {
        if (cam.backgroundColor != dimension) {
            // Debug.Log("1");
            // Debug.Log(dimension);
            // Debug.Log(cam.backgroundColor);
            if (cir && gameObject.tag != "Enemy")
                cir.enabled = false;
            if (pol && gameObject.tag != "Enemy")
                pol.enabled = false;
            if (box && gameObject.tag != "Enemy")
                box.enabled = false;
            sr.enabled = false;
        }
        else if (cam.backgroundColor == dimension) {
            // Debug.Log("0");
            // Debug.Log(dimension);
            // Debug.Log(cam.backgroundColor);
            if (cir)
                cir.enabled = true;
            if (pol)
                pol.enabled = true;
            if (box)
                box.enabled = true;
            sr.enabled = true;
        }
    }
}
