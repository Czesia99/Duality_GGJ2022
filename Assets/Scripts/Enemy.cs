using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3f;
    [SerializeField] private float attackDamage = 1f;
    [SerializeField] private float health = 1f;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        if (target != null) {
            transform.position = Vector2.MoveTowards(transform.position, target.position, step);
        }
    }

    public void UpdateHealth(float mod)
    {
        health += mod;
        if (health <= 0f)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionStay2D(Collision2D other) {
        if (other.gameObject.tag == "Player") {
            other.gameObject.GetComponent<PlayerHealth>().UpdateHealth(-attackDamage);
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("trigger");
        if (other.gameObject.tag == "Player") {
            target = other.transform;
        }
    }

    // private void OnTriggerExit2D(Collider2D other) {
    //     target = null;
    // }
}
