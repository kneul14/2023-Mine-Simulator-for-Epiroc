using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traffic_Light_Script : MonoBehaviour
{
    public GameObject truck, truck2, machineTagPoint, greenLight, amberLight, redLight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((truck == null || truck.activeInHierarchy == false) && (truck2 == null || truck2.activeInHierarchy == false))
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
            amberLight.SetActive(true);
            StartCoroutine("RedLight");
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "MineTruck")
        {
            amberLight.SetActive(false);
            greenLight.SetActive(true);
            StopAllCoroutines();
        }
    }

    IEnumerator RedLight()
    {
        yield return new WaitForSeconds(1f);
        redLight.SetActive(true);
    }
}
