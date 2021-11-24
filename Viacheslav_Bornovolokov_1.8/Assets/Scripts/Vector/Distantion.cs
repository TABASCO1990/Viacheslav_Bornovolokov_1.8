using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distantion : MonoBehaviour
{
    public Transform obj_1;
    public Transform obj_2;
    public float distantion;
    private bool go = true;
    public float distantionStop;

    private void Update()
    {
        if (go)
        {
            distantion = Vector3.Distance(obj_1.position, obj_2.position);
            obj_1.transform.Translate(Vector3.forward * 1f * Time.deltaTime);
            obj_2.transform.Translate(-Vector3.forward * 1f * Time.deltaTime);
        }
        // Отсанавливаем обьекты когда растояние между ними превышено
        if (distantion > distantionStop && go)
        {           
            Debug.Log("растояние между обьектами: " + distantion);
            go = false;           
        }       
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(obj_1.position, obj_2.position); 
    }
}
