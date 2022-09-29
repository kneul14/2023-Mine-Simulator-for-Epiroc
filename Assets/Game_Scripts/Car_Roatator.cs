using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Roatator : MonoBehaviour
{
    public float degreeToRotate;
    public GameObject volvoCar;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RotateCar()
    {
        Debug.Log("rotating."); //car is rotating  
        volvoCar.transform.eulerAngles = new Vector3(
        volvoCar.transform.eulerAngles.x,
        volvoCar.transform.eulerAngles.y + degreeToRotate,
        volvoCar.transform.eulerAngles.z);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "VolvoCar")
        {
            RotateCar();
        }
    }
}
