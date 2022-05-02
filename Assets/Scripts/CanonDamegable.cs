using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonDamegable : MonoBehaviour
{
    public int damge = 10;

    public void getDamge()
    {
        Ship.health -= damge;
    }
}
