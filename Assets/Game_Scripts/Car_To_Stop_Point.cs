using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UI;

public class Car_To_Stop_Point : MonoBehaviour
{
    public float dist1, focusedDist;
    public GameObject car, mineTruck1, mineTruck2, mineTruck3, mineTruck4, mineTruck5;
    public Truck_Spawner truck_spawner_Script;
    public GameObject[] tagPoints;
    public TMP_Text distText;
    public float[] distArray; 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        tagPoints = GameObject.FindGameObjectsWithTag("TruckTP");
        SetTruck();

        GameObject nearest = tagPoints[0];

        float nearestDist = GetDistance(nearest);
        foreach (GameObject t in tagPoints) {

            if(car.transform.position.x > t.transform.position.x)
            {
                if(GetDistance(t) < nearestDist)
                {
                    nearestDist = GetDistance(t);
                    nearest= t;
                }
            }
        }

        focusedDist = nearestDist - 3;

        distText.text = string.Format("{00} M", (int)focusedDist);
    }

    void SetTruck()
    {
        mineTruck1 = truck_spawner_Script.GetComponent<Truck_Spawner>().truck1;
        mineTruck2 = truck_spawner_Script.GetComponent<Truck_Spawner>().truck2;
        mineTruck3 = truck_spawner_Script.GetComponent<Truck_Spawner>().truck3;
        mineTruck4 = truck_spawner_Script.GetComponent<Truck_Spawner>().truck4;
        mineTruck5 = truck_spawner_Script.GetComponent<Truck_Spawner>().truck5;
    }

    float GetDistance(GameObject tag)
    {
        Vector3 VecDist1 = car.transform.position - tag.transform.position;
        float dist1 = VecDist1.magnitude;
        return dist1;
    }
}
