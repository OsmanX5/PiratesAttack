using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public float ShootPower = 10f;
    public GameObject particalse;
    GameObject DestroyGround;
    Rigidbody rb;

    private void Awake()
    {
        DestroyGround = GameObject.FindGameObjectWithTag("DestroyGround");
        rb = this.GetComponent<Rigidbody>();
    }

    private void Start()
    {
        print("I created");
        rb.AddForce(Vector3.up*ShootPower);
    }
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == DestroyGround) DestroyFtuit();
    }
    private void Update()
    {
        
    }
    public void DestroyFtuit()
    {
        Instantiate(particalse, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
