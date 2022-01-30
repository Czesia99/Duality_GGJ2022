using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameObject laserPrefab;

    public float bulletForce = 20f;
    public AudioClip shotSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            Shoot();
            SpecialEffectsHelper.Instance.Explosion(transform.position);
        }
        if (Input.GetButtonDown("Fire2"))
        {
            ShootLaser();
        }
    }

    void Shoot()
    {
        AudioSource.PlayClipAtPoint(shotSound, transform.position);
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }

    void ShootLaser()
    {
        GameObject laser = Instantiate(laserPrefab, firePoint.position, firePoint.rotation);
        if (Input.GetButtonUp("Fire2"))
            Destroy(laser);
        // Rigidbody2D rb = laser.GetComponent<Rigidbody2D>();
        // rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
