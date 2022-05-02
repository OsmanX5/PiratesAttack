using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    public GameObject Ball;
    public Transform shootingPoint;
    public Vector2 shootingTime = new Vector2(3f,10f);
    public ParticleSystem ps;
    AudioSource aud;
    public AudioClip cannonExplosion;
    private void Start()
    {
        StartCoroutine(shootAfruit(Ball, shootingPoint));
        aud = this.GetComponent<AudioSource>();
    }

    IEnumerator shootAfruit(GameObject fruit,Transform shootingPoint)
    {
        yield return new WaitForSeconds(Random.Range(shootingTime.x, shootingTime.y));
        while (true)
        {
            ps.Play();
            aud.PlayOneShot(cannonExplosion);
            Instantiate(fruit, shootingPoint.position, shootingPoint.rotation);
            yield return new WaitForSeconds(Random.Range(shootingTime.x, shootingTime.y));
        }
    }
}
