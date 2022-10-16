using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traffic_Light_Script : MonoBehaviour
{
    public GameObject truck, machineTagPoint, greenLight, amberLight, redLight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (truck == null || truck.activeInHierarchy == false)
        {
            if(machineTagPoint != null)
            {
                Destroy(machineTagPoint);
            }
            Destroy(gameObject);
        }
    }

    private void Awake()
    {
        greenLight.SetActive(true);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "MineTruck")
        {
            greenLight.SetActive(false);
            redLight.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "MineTruck")
        {
            redLight.SetActive(false);
            greenLight.SetActive(true);
        }
    }
}
