using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete_14 : MonoBehaviour
{
    public GameObject mineTruck14, MT14TP;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(mineTruck14.activeInHierarchy == false)
        {
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "VolvoCar")
        {
            Destroy(MT14TP);
        }
    }
}
