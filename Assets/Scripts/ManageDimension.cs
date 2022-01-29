using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageDimension : MonoBehaviour
{
    public Camera cam;
    CircleCollider2D cir;
    SpriteRenderer sr;
    Color objectColor;

    // Update is called once per frame
    void Start() 
    {
        cam = Camera.main;
        cir = gameObject.GetComponent<CircleCollider2D>();
        sr = gameObject.GetComponent<SpriteRenderer>();
        objectColor = sr.color;  
    }
    void Update()
    {
        if (cam.backgroundColor == objectColor)
            cir.enabled = false;
        else
            cir.enabled = true;
    }
}
