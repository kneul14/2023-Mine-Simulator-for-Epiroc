using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HeadLight_Truck_mover : MonoBehaviour
{
    Transform target;
    public GameObject DPGO;
    public NavMeshAgent navMesh; //reference to the Nav Mesh stateName;
    public float enemySpeed = 10f;
    private int wavePointIndex = 0;
    Truck_HeadLight_Changer truck_HeadLight_Changer_Script;
    public Vector3 gopos;

    private void Start()
    {
        Drive_Points drive_Points_Script = DPGO.GetComponent<Drive_Points>();
        target = DPGO.GetComponent<Drive_Points>().drivePoints[0];

        truck_HeadLight_Changer_Script = GetComponentInParent<Truck_HeadLight_Changer>();

        navMesh = GetComponent<NavMeshAgent>();
        gopos = GetComponent<Transform>().position;
    }

    private void Update()
    {
    }

    public void EnemyWanderMovement()
    {
        navMesh.isStopped = false;
        navMesh.SetDestination(target.position);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextPathWayPoint();
        }
    }

    public void EnemyWanderPause()
    {
        navMesh.isStopped = true;
    }

    void ContinueMoving()
    {
        navMesh.SetDestination(target.position);
        wavePointIndex = -1;
        wavePointIndex++;

        target = DPGO.GetComponent<Drive_Points>().drivePoints[wavePointIndex];
    }

    void GetNextPathWayPoint() //cycles through the PathWayPoints in the world 
    {

        if (wavePointIndex >= DPGO.GetComponent<Drive_Points>().drivePoints.Length - 1) //If the enemy reaches the end pont then the Gameobject gets destroyed.
        {
            Destroy(gameObject);
            ContinueMoving();
            return;
        }
        wavePointIndex++;
        target = DPGO.GetComponent<Drive_Points>().drivePoints[wavePointIndex];
    }
}
