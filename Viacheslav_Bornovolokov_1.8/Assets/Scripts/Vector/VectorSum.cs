using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;


public class VectorSum : MonoBehaviour
{
    public Transform V1;
    public Transform V2;
    public Transform VectorRes;
     private int rand1;
    private int rand2;
    private void Start()
     {
         Random random = new Random();
         rand1 = random.Next(3, 7);
         rand2 = random.Next(3, 7);
    }
    private void Update()
      {
       
        if (V1.transform.position.z < rand1)
        {
            V1.transform.Translate(Vector3.forward * 2f * Time.deltaTime);
        }
        if (V2.transform.position.z < rand2)
        {
            V2.transform.Translate(Vector3.forward * 2f * Time.deltaTime);
        }

        Invoke("SumVector", 3f);      
    }

    public void SumVector()
    {
        VectorRes.transform.position = V1.transform.position + V2.transform.position;
    }
}

