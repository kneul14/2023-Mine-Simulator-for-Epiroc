using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tag_Point_Detection : MonoBehaviour
{
    public GameObject forkLift;
    public GameObject greenLight;
    public GameObject amberLight;
    public GameObject redLight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetLight();
    }

    void SetLight()
    {        
        if (redLight.activeSelf)
        {
            Debug.Log("Light is red."); //Light is red.            
            //Create Coroutine for 2 secons and chage back to green.
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "ForkLift")
        {
            //forkLift.SetActive(false);
            greenLight.SetActive(false);
            redLight.SetActive(true);
        }
    }
}
