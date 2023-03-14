using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMaker : MonoBehaviour
{

    public GameObject sphereObj; 

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++);
        {
           
            Instantiate(sphereObj, transform.position, Quaternion.identity);
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
