using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifetime : MonoBehaviour
{
    public float lifetime = 10f;
    void Update()
    {
        lifetime -= Time.deltaTime;
        if (lifetime <= 0) Destroy(this.gameObject);
    }
}
