using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class ActionsManger : MonoBehaviour
{
    
    public void SlowDownTheTime()
    {
        Time.timeScale = 0.5f;
    }
    public void NormalTime()
    {
        Time.timeScale = 1;
    }
}
