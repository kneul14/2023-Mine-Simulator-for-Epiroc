using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Truck_HeadLight_Changer : MonoBehaviour
{
    public GameObject[] headLights;
    public GameObject greenHLight, redHLight;
    public bool rBool, gBool, isColliding;
    public HeadLight_Truck_mover HeadLight_Truck_mover_Script;

    // Start is called before the first frame update
    void Start()
    {
        HeadLight_Truck_mover_Script = GetComponentInParent<HeadLight_Truck_mover>();
        ActivateHLight();
    }

    // Update is called once per frame
    void Update()
    {
        if (greenHLight.activeInHierarchy)
        {
            rBool = false;
            gBool = true;
        }

        if (redHLight.activeInHierarchy)
        {
            gBool = false;
            rBool = true;
            //HeadLight_Truck_mover_Script.EnemyWanderMovement();
        }

        if (isColliding == false && gBool == true)
        {
            HeadLight_Truck_mover_Script.EnemyWanderMovement();
        }

        if (rBool == true)
        {
            HeadLight_Truck_mover_Script.EnemyWanderMovement();
        }
    }

    void ActivateHLight()
    {
        if(headLights != null)
        headLights[Random.Range(0, headLights.Length)].SetActive(false);

    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "VolvoCar")
        {
            isColliding = true;
            HeadLight_Truck_mover_Script.EnemyWanderPause();
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "VolvoCar")
        {
            if (gBool == true)
            {
                if (HeadLight_Truck_mover_Script.DPGO != null)
                {
                    isColliding = false;
                    HeadLight_Truck_mover_Script.EnemyWanderMovement();
                }
            }
        }
    }
}
