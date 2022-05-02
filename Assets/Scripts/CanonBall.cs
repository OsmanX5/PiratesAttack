using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonBall : MonoBehaviour
{
    public float ShootPower = 10f;
    public GameObject particalse;
    Rigidbody rb;

    private void Awake()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    private void Start()
    {
        rb.AddForce(transform.forward*ShootPower);
    }
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<CanonDamegable>() != null)
        {
            collision.gameObject.GetComponent<CanonDamegable>().getDamge();
            this.DestroyBall(true);
        }
    }

    public void DestroyBall(bool effect)
    {
        if (effect)
        {
            Instantiate(particalse, transform.position, Quaternion.identity);
        }
        
        Destroy(this.gameObject);
    }
}
