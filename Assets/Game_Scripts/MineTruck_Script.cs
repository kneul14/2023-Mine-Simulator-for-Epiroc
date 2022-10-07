using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MineTruck_Script : MonoBehaviour
{
    Transform target;
    public GameObject DPGO;
    //public Drive_Points drive_Points_Script;
    NavMeshAgent navMesh; //reference to the Nav Mesh stateName;
    public float enemySpeed = 10f;
    private int wavePointIndex = 0;

    private void Start()
    {
        //target = Drive_Points.drivePoints[0];

        Drive_Points drive_Points_Script = DPGO.GetComponent<Drive_Points>();
        target = DPGO.GetComponent<Drive_Points>().drivePoints[0];

        navMesh = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        EnemyWanderMovement();
    }

    public void EnemyWanderMovement()
    {
        navMesh.SetDestination(target.position);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextPathWayPoint();
        }
    }

    void ContinueMoving()
    {
        navMesh.SetDestination(target.position);
        wavePointIndex = -1;
        wavePointIndex++;
        //target = Drive_Points.drivePoints[wavePointIndex];

        target = DPGO.GetComponent<Drive_Points>().drivePoints[wavePointIndex];
    }

    void GetNextPathWayPoint() //cycles through the PathWayPoints in the world 
    {
        //if (wavePointIndex >= Drive_Points.drivePoints.Length - 1) //If the enemy reaches the end pont then the Gameobject gets destroyed.
        //{
        //    ContinueMoving();
        //    return;
        //}
        if (wavePointIndex >= DPGO.GetComponent<Drive_Points>().drivePoints.Length - 1) //If the enemy reaches the end pont then the Gameobject gets destroyed.
        {
            ContinueMoving();
            return;
        }
        wavePointIndex++;
        //target = Drive_Points.drivePoints[wavePointIndex];
        target = DPGO.GetComponent<Drive_Points>().drivePoints[wavePointIndex];
    }
}