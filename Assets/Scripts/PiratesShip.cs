using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiratesShip : MonoBehaviour
{
    public static int maxHealth = 100;
    public static int health;
    private static float precentageHealth;

    public static float PrecentageHealth { get => health * 1.0f / maxHealth; set => precentageHealth = value; }

    private void Awake()
    {
        health = maxHealth;
    }
}
