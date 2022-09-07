using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Forklift_Script : MonoBehaviour
{
    private Transform target;
    NavMeshAgent navMesh; //reference to the Nav Mesh stateName;
    public float enemySpeed = 10f;
    private int wavePointIndex = 0;

    public GameObject enemyPlayerPanel;

    public bool isPlayerSeen;
    public bool isPlayerLocationKnown;

    private void Start()
    {
        target = Drive_Points.drivePoints[0];
        navMesh = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (isPlayerLocationKnown == true)
        {
            enemyPlayerPanel.SetActive(true);
        }
        else
        {
            enemyPlayerPanel.SetActive(false);
        }
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
        //target.position = Drive_Points.drivePoints[0].position;
        navMesh.SetDestination(target.position);
        wavePointIndex = -1;
        wavePointIndex++;
        target = Drive_Points.drivePoints[wavePointIndex];
    }

    void GetNextPathWayPoint() //cycles through the PathWayPoints in the world 
    {
        if (wavePointIndex >= Drive_Points.drivePoints.Length - 1) //If the enemy reaches the end pont then the Gameobject gets destroyed.
        {
            ContinueMoving();
            return;
        }
        wavePointIndex++;
        target = Drive_Points.drivePoints[wavePointIndex];
    }
}