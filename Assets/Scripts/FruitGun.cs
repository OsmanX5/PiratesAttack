using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitGun : MonoBehaviour
{
    public GameObject fruit;
    public Transform shootingPoint;

    private void Start()
    {
        StartCoroutine(shootAfruit(fruit, shootingPoint));
    }

    IEnumerator shootAfruit(GameObject fruit,Transform shootingPoint)
    {
        while (true)
        {
            Instantiate(fruit, shootingPoint.position, Quaternion.identity);

            yield return new WaitForSeconds(5f);
        }

        
    }
}
