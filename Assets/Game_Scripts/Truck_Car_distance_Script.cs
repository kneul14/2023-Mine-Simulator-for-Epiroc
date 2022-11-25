using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UI;

public class Truck_Car_distance_Script : MonoBehaviour
{
    public float dist1, dist2, dist3, dist4, dist5, focusedDist;
    Vector3 VecDist1, VecDist2, VecDist3, VecDist4, VecDist5;
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
        SetDistance1();
        SetDistance2();
        SetDistance3();
        SetDistance4();
        SetDistance5();
        SortDistanceOrder();
    }

    void SetTruck()
    {
        mineTruck1 = truck_spawner_Script.GetComponent<Truck_Spawner>().truck1;
        mineTruck2 = truck_spawner_Script.GetComponent<Truck_Spawner>().truck2;
        mineTruck3 = truck_spawner_Script.GetComponent<Truck_Spawner>().truck3;
        mineTruck4 = truck_spawner_Script.GetComponent<Truck_Spawner>().truck4;
        mineTruck5 = truck_spawner_Script.GetComponent<Truck_Spawner>().truck5;
    }

    void SetDistance1()
    {
        VecDist1 = car.transform.position - mineTruck1.transform.position;
        dist1 = VecDist1.magnitude;
    }

    void SetDistance2()
    {
        VecDist2 = car.transform.position - mineTruck2.transform.position;
        dist2 = VecDist2.magnitude;
    }
    void SetDistance3()
    {
        VecDist3 = car.transform.position - mineTruck3.transform.position;
        dist3 = VecDist3.magnitude;
    }
    void SetDistance4()
    {
        VecDist4 = car.transform.position - mineTruck4.transform.position;
        dist4 = VecDist4.magnitude;
    }
    void SetDistance5()
    {
        VecDist5 = car.transform.position - mineTruck5.transform.position;
        dist5 = VecDist5.magnitude;
    }

    public void SortDistanceOrder()
    {

        distArray = new float[] { dist1, dist2, dist3, dist4, dist5 };
        Array.Sort(distArray);

        if (car.transform.position.x > tagPoints[0].transform.position.x)
        {
            focusedDist = distArray[0];
        }
        if (car.transform.position.x < tagPoints[0].transform.position.x /*|| (car.transform.position.x > mineTruck1.transform.position.x && mineTruck1.transform.position.x < tagPoints[0].transform.position.x)*/)
        {
            focusedDist = distArray[1];
        }
        if (car.transform.position.x < tagPoints[1].transform.position.x /*|| (car.transform.position.x > mineTruck2.transform.position.x && mineTruck2.transform.position.x < tagPoints[0].transform.position.x)*/)
        {
            focusedDist = distArray[2];

        }
        if (car.transform.position.x < tagPoints[2].transform.position.x /*|| (car.transform.position.x > mineTruck3.transform.position.x && mineTruck3.transform.position.x < tagPoints[0].transform.position.x)*/)
        {
            focusedDist = distArray[3];

        }
        if (car.transform.position.x < tagPoints[3].transform.position.x /*|| (car.transform.position.x > mineTruck4.transform.position.x && mineTruck4.transform.position.x < tagPoints[0].transform.position.x)*/)
        {
            focusedDist = distArray[4];

        }
        if (car.transform.position.x < tagPoints[4].transform.position.x /*|| (car.transform.position.x > mineTruck5.transform.position.x && mineTruck5.transform.position.x < tagPoints[0].transform.position.x)*/)
        {

        }

        distText.text = string.Format("{00} M", (int)focusedDist);
    }

    public void IsTruckCloser()
    {
        //if(car.transform.position.x < mineTruck1.transform.position.x)
        //{ focusedDist = distArray[3]; }
        //if (car.transform.position.x < mineTruck1.transform.position.x)
        //{ focusedDist = dist2; }

        { 
        //if (mineTruck1.transform.position.x < tagPoints[0].transform.position.x)
        //{
        //    focusedDist = dist1;
        //    if (mineTruck1.transform.position.x > car.transform.position.x)
        //    {
        //        focusedDist = dist2;
        //    }
        //} 


        //if (mineTruck2.transform.position.x < car.transform.position.x)
        //{
        //    focusedDist = dist2;
        //}


        //if (mineTruck3.transform.position.x < car.transform.position.x)
        //{
        //    focusedDist = dist3;
        //}

        //if (mineTruck4.transform.position.x < car.transform.position.x)
        //{
        //    focusedDist = dist4;
        //}

        //if (mineTruck5.transform.position.x < car.transform.position.x)
        //{
        //    focusedDist = dist5;
        //}
        }
    }
}
