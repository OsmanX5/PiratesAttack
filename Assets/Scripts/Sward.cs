using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sward : MonoBehaviour
{
    GameObject hited;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Fruit>() != null)
        {
            hited = collision.gameObject;
            hited.GetComponent<Fruit>().DestroyFtuit();
        }
    }
}
