using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public Transform SelfTransform;
    private Vector3 force;
    private bool isAccelerated;

    public void LeftRotation()
    {
        SelfTransform.Rotate(0, 0, 5);
    }
    public void RightRotation()
    {
        SelfTransform.Rotate(0, 0, -5);
    }
    public void Acceleration()
    {
        isAccelerated = true;
        force += (SelfTransform.up * Time.deltaTime) * 0.1f;
    }
    
    void LateUpdate()
    {
        if(!isAccelerated)
        {
            force = Vector3.Lerp(force, Vector3.zero, Time.deltaTime);
        }
        SelfTransform.position += force;
        isAccelerated = false;

    }
}
