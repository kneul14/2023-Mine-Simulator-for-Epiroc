using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive_Points : MonoBehaviour
{
    public static Transform[] drivePoints;

    void Awake()
    {
        //Counts the children and creates that many children in the array and then loops through them
        drivePoints = new Transform[transform.childCount];
        for (int i = 0; i < drivePoints.Length; i++)
        {
            drivePoints[i] = transform.GetChild(i);
        }
    }
}
