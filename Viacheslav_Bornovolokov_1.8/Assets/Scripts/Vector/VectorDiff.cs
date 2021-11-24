using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class VectorDiff : MonoBehaviour
{
    public Transform V1;
    public Transform V2;
    public Transform VectorRes;

    int rand1;
    int rand2;
    private void Start()
    {
        Random random = new Random();
        rand1 = random.Next(7, 10);
        rand2 = random.Next(7, 10);
        
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

        Invoke("DifVector", 3f);
    }

    public void DifVector()
    {
        
        VectorRes.transform.position = V1.transform.position - V2.transform.position;
    }
}
