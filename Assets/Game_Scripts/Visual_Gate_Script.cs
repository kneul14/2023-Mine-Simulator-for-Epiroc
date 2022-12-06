using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UI;
public class Visual_Gate_Script : MonoBehaviour
{
    public float dist1, focusedDist, truckDistFromPoint;
    public GameObject car, mineTruck1, mineTruck2, mineTruck3, mineTruck4, mineTruck5;
    public Truck_Spawner truck_spawner_Script;
    public GameObject[] tagPoints;
    public float[] distArray;

    public GameObject line, wayPoint1, wayPoint2;
    public float lineSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        line.transform.position = wayPoint1.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        SetTruck();
        tagPoints = GameObject.FindGameObjectsWithTag("TruckTP");
        
        TPCalc();

        IsLowered();

    }

    void SetTruck()
    {
        mineTruck1 = truck_spawner_Script.GetComponent<Truck_Spawner>().truck1;
        mineTruck2 = truck_spawner_Script.GetComponent<Truck_Spawner>().truck2;
        mineTruck3 = truck_spawner_Script.GetComponent<Truck_Spawner>().truck3;
        mineTruck4 = truck_spawner_Script.GetComponent<Truck_Spawner>().truck4;
        mineTruck5 = truck_spawner_Script.GetComponent<Truck_Spawner>().truck5;
    }

    private void TPCalc()
    {
        GameObject nearest = tagPoints[0];

        float nearestDist = GetDistance(nearest);
        foreach (GameObject t in tagPoints)
        {
            if (car.transform.position.x > t.transform.position.x)
            {
                if (GetDistance(t) < nearestDist)
                {
                    nearestDist = GetDistance(t);
                    nearest = t;
                }
            }
        }

        focusedDist = nearestDist - 3;
    }

    float GetDistance(GameObject tag)
    {
        Vector3 VecDist1 = car.transform.position - tag.transform.position;
        float dist1 = VecDist1.magnitude;
        return dist1;
    }

    void IsLowered()
    {
        if(focusedDist < 40)
        {
            line.transform.position = Vector3.MoveTowards(line.transform.position, wayPoint2.transform.position, lineSpeed * Time.deltaTime);
        }
        else { line.transform.position = Vector3.MoveTowards(line.transform.position, wayPoint1.transform.position, 0.7f * Time.deltaTime); }

        //if(truckDistFromPoint > 20)
        //{
        //    line.transform.position = Vector3.MoveTowards(line.transform.position, wayPoint1.transform.position, 0.7f * Time.deltaTime);
        //}
    }
}
