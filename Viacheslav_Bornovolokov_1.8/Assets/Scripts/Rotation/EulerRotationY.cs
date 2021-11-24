using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EulerRotationY : MonoBehaviour
{
    public float RotateY;

    public float t = 0;

    public float Amp = 0.25f;

    public float Freq = 2;

    public float Offset = 0f;

    private Vector3 StartPos;

    private void Start()
    {
        StartPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        Offset = Amp * Mathf.Sin(t * Freq); // Колебание
        transform.position = StartPos + new Vector3(0, Offset,0);
        transform.eulerAngles += new Vector3(0,RotateY,0) * Time.deltaTime;
        
    }
}
