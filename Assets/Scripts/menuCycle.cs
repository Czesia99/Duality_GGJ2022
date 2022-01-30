using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuCycle : MonoBehaviour
{
    public Camera cam;
    public Color black = Color.black;
    public Color white = Color.white;
    private float time = 2.2f;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        cam.backgroundColor = black;
        StartCoroutine(Cycle());
    }

    // Update is called once per frame
    IEnumerator Cycle()
    {
        if (cam.backgroundColor == black)
            cam.backgroundColor = white;
        else
            cam.backgroundColor = black;
        yield return new WaitForSeconds(time);
        StartCoroutine(Cycle());
    }
}
