using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction;
using UnityEngine.InputSystem;
public class ButtonsRead : MonoBehaviour
{
    static public InputActionReference Rgrip;
    public InputActionReference _Rgrip;

    static public InputActionReference Lgrip;
    public InputActionReference _Lgrip;

    static public InputActionReference Rtrigger;
    public InputActionReference _Rtrigger;

    static public InputActionReference Ltrigger;
    public InputActionReference _Ltrigger;

    private void Awake()
    {
        Rgrip     = _Rgrip;
        Lgrip     = _Lgrip;
        Rtrigger  = _Rtrigger;
        Ltrigger  = _Ltrigger;
    }
}
