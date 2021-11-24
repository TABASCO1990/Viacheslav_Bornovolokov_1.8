using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;
public class VectorMult : MonoBehaviour
{
    public Transform V1;
    public float numMult;
    public Transform V2;
    [SerializeField] private int rand;
    void Start()
    {
        Random random = new Random();
        rand = random.Next(2, 5);

    }


    void Update()
    {
        
        if (V1.transform.position.z < rand)
        {
            V1.transform.Translate(Vector3.forward * 2f * Time.deltaTime);
        }

        Invoke("MultVector", 3f);
    }
    public void MultVector()
    {
        V2.position = V1.position * numMult;
    }
}
