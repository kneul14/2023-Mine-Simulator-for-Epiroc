using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truck_Spawner : MonoBehaviour
{
    private GameObject[] trucksGO;
    private Transform[] trucks;
    public GameObject truck1, truck2, truck3, truck4, truck5;


    // Start is called before the first frame update
    void Start()
    {
        SpawnTrucks();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Awake()
    {
        trucksGO = GameObject.FindGameObjectsWithTag("MineTruck");

        trucks = new Transform[trucksGO.Length];

        for (int i = 0; i < trucksGO.Length; i++)
        {
            trucks[i] = trucksGO[i].transform;
        }
    }

    void SpawnTrucks()
    {
        truck1 = trucksGO[Random.Range(0, trucks.Length)];
        if (truck1 == truck5 || truck1 == truck2 || truck1 == truck3 || truck1 == truck4)
        {
            truck2 = trucksGO[Random.Range(0, trucks.Length)];
            truck3 = trucksGO[Random.Range(0, trucks.Length)];
            truck4 = trucksGO[Random.Range(0, trucks.Length)];
            truck5 = trucksGO[Random.Range(0, trucks.Length)];
        }

        truck2 = trucksGO[Random.Range(0, trucks.Length)];
        if(truck2 == truck1 || truck2 == truck3 || truck2 == truck4 || truck2 == truck5)
        {
            truck2 = trucksGO[Random.Range(0, trucks.Length)];
        }

        truck3 = trucksGO[Random.Range(0, trucks.Length)];
        if (truck3 == truck1 || truck3 == truck2 || truck3 == truck4 || truck3 == truck5)
        {
            truck3 = trucksGO[Random.Range(0, trucks.Length)];
        }


        truck4 = trucksGO[Random.Range(0, trucks.Length)];
        if (truck4 == truck1 || truck4 == truck2 || truck4 == truck3 || truck4 == truck5)
        {
            truck4 = trucksGO[Random.Range(0, trucks.Length)];
        }


        truck5 = trucksGO[Random.Range(0, trucks.Length)];
        if (truck5 == truck1 || truck5 == truck2 || truck5 == truck3 || truck5 == truck4)
        {
            truck5 = trucksGO[Random.Range(0, trucks.Length)];
        }

        foreach (GameObject child in trucksGO)
        {
            child.SetActive(false);
        }
           
        truck1.SetActive(true);
        truck2.SetActive(true);
        truck3.SetActive(true);
        truck4.SetActive(true);
        truck5.SetActive(true);

    }
}        
