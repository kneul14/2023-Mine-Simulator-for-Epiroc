using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Forklift_Nav_Mesh : MonoBehaviour
{
    NavMeshAgent navMesh; //reference to the Nav Mesh
    [SerializeField] Transform currentPos;
    
    float s = 2.0f;

    private Forklift_Script forkliftScript;

    private void Awake()
    {
        navMesh = GetComponent<NavMeshAgent>();
    }

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        Drive();
    }

    public void Drive()
    {
        transform.LookAt(currentPos);
        //Debug.Log("Driving");
    }
}