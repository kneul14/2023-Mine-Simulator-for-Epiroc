using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truck_Spawner : MonoBehaviour
{
    [SerializeField] public GameObject[] trucksGO;
    [SerializeField] public Transform[] trucks;
    public GameObject truck1, truck2, truck3;


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
        truck2 = trucksGO[Random.Range(0, trucks.Length)];
        if(truck2 == truck1)
        {
            truck2 = trucksGO[Random.Range(0, trucks.Length)];
        }
        truck3 = trucksGO[Random.Range(0, trucks.Length)];
        if (truck3 == truck1 || truck3 == truck2)
        {
            truck3 = trucksGO[Random.Range(0, trucks.Length)];
        }

        foreach (GameObject child in trucksGO)
        {
            child.SetActive(false);
        }
           
        truck1.SetActive(true);
        truck2.SetActive(true);
        truck3.SetActive(true);

    }
}        
