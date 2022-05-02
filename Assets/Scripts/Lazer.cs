using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer : MonoBehaviour
{
    public float ShootPower = 500f;
    public GameObject LazerExplosionParticalse;
    Rigidbody rb;
    private void Awake()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    private void Start()
    {
        StartCoroutine(shoot());
    }

    IEnumerator shoot()
    {
        yield return new WaitForSeconds(0.2f);
        Debug.Log("shooted");
        rb.AddForce(transform.forward * ShootPower);
        yield return null;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<CanonBall>() != null)
        {
            collision.gameObject.GetComponent<CanonBall>().DestroyBall(false);
            Player.score += 1;
            this.DestroyLazer(true);
        }
        if (collision.gameObject.GetComponent<PiratesShip>() != null)
        {
            PiratesShip.health -= 10;
            this.DestroyLazer(true);
        }
    }

    public void DestroyLazer(bool effect)
    {
        if (effect)
        {
            Instantiate(LazerExplosionParticalse, transform.position, Quaternion.identity);
        }

        Destroy(this.gameObject);
    }
}
