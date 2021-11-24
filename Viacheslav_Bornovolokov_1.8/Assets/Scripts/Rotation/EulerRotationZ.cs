using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EulerRotationZ : MonoBehaviour
{
    public float RotateZ;
    void Update()
    {
        transform.Rotate(new Vector3(0,0,RotateZ) * Time.deltaTime);
    }
}
