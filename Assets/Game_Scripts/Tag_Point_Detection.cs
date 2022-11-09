using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "MineTruck")
        {

        }
    }

    void TruckInScene()
    {
        if(mineTruck == null)
        {
            Destroy(this.gameObject);
        }
    }
}
