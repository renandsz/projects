using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum LookMode
{
    inputRaw,
    input,
    target,
    mouse


}

public class CustomLook : MonoBehaviour
{
    public Transform target;
    public float angle;
    public LookMode mode;
    private float x, y,xRaw, yRaw;
    public void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        xRaw = Input.GetAxisRaw("Horizontal");
        yRaw = Input.GetAxis("Vertical");
        
        switch (mode)
        {
            case LookMode.inputRaw:
                RotateToInputRaw();
                break;
            case LookMode.input:
                RotateToInput();
                break;
            case LookMode.target:
                RotateToTarget();
                break;
            case LookMode.mouse:
                RotateToMouse();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    private void RotateToInputRaw()
    {
        angle = Mathf.Atan2(yRaw, xRaw) * Mathf.Deg2Rad;
    }
    private void RotateToInput()
    {
        angle = Mathf.Atan2(yRaw, xRaw) * Mathf.Deg2Rad;
    }
    private void RotateToTarget()
    {
        angle = Mathf.Atan2(yRaw, xRaw) * Mathf.Deg2Rad;
    }
    private void RotateToMouse()
    {
        angle = Mathf.Atan2(yRaw, xRaw) * Mathf.Deg2Rad;
    }
}
