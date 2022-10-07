using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traffic_Light_Script : MonoBehaviour
{
    public GameObject truck, machineTagPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (truck == null || truck.activeInHierarchy == false)
        {
            Destroy(machineTagPoint);
            Destroy(gameObject);
        }
    }
}
