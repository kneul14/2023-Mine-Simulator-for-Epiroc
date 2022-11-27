using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tag_Point_Detection : MonoBehaviour
{
    public GameObject mineTruck;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Awake()
    {
        TruckInScene();
    }

    // Update is called once per frame
    void Update()
    {
        TruckInScene();

    }

    private void OnTriggerEnter(Collider collider)
    {
        if (mineTruck && collider.gameObject.tag == "MineTruck")
        {
            Destroy(this.gameObject);
        }
    }

    void TruckInScene()
    {
        if (mineTruck == null)
        {
            Destroy(this.gameObject);
        }

        if (mineTruck.activeSelf == false)
        {
            Destroy(this.gameObject);
        }
    }
}
