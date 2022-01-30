using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public static int score = 0;
    public Camera cam;
    Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cam.backgroundColor == Color.white)
            scoreText.color = Color.black;
        else
            scoreText.color = Color.white;
        scoreText.text = "Score: " + score;
    }
}
