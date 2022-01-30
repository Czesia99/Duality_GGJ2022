using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private float health = 0f;
    [SerializeField] private float maxHealth = 3;
    // Start is called before the first frame update
    void Start() {
        health = maxHealth;
    }

    // Update is called once per frame
    public void UpdateHealth(float mod)
    {
        health += mod;
        if (health <= 0f) {
            Debug.Log("DEAD / LOAD MENU");
        }
    }
}
