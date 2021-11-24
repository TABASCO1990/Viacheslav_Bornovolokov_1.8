using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EulerRotationX : MonoBehaviour
{
    
    public float RotateX;
   
    void Update()
    {
        
        if(transform.rotation.x <= 90)
        transform.Rotate(new Vector3(RotateX,0,0) * Time.deltaTime);
        
    }
}
