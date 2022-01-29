using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cycle : MonoBehaviour
{
    public Camera cam;
    public Color black = Color.black;
    public Color white = Color.white; 

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        cam.backgroundColor = black;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (cam.backgroundColor == black)
                cam.backgroundColor = white;
            else
                cam.backgroundColor = black;
        }
    }
}
