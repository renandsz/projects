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
                CalcAngleFromInputRaw();
                break;
            case LookMode.input:
                CalcAngleFromInput();
                break;
            case LookMode.target:
                CalcAngleFromTargetObj();
                break;
            case LookMode.mouse:
                CalcAngleFromMousePos();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
        
        SelfRotate();
    }

    private void CalcAngleFromInputRaw()
    {
        angle = Mathf.Atan2(yRaw, xRaw) * Mathf.Rad2Deg;
    }
    private void CalcAngleFromInput()
    {
        angle = Mathf.Atan2(y, x) * Mathf.Rad2Deg;
    }
    private void CalcAngleFromTargetObj()
    {
        Vector2 dir = (transform.position - target.position).normalized
        angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
    }
    private void CalcAngleFromMousePos()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 dir = (transform.position - mousePos).normalized
        angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;}

    void SelfRotate()
    {
        transform.rotation = Quaternion.Euler(0,0,angle);
    }
}
