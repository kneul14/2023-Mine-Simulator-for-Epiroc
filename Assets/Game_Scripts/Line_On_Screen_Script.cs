using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line_On_Screen_Script : MonoBehaviour
{
    public GameObject line, wayPoint1, wayPoint2;
    public GameObject[] waypoints;
    int wayPointIndex = 0;
    float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(line.transform.position, waypoints[wayPointIndex].transform.position) < .01f)
        {
            wayPointIndex ++;
            if(wayPointIndex >= waypoints.Length)
            {
                wayPointIndex = 0;
            }
        }

        line.transform.position = Vector3.MoveTowards(line.transform.position, waypoints[wayPointIndex].transform.position, speed * Time.deltaTime);
    }
}
