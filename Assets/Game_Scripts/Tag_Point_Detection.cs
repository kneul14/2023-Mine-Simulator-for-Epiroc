using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tag_Point_Detection : MonoBehaviour
{
    public GameObject mineTruck;
    public GameObject line, wayPoint1, wayPoint2;
    Visual_Gate_Script Visual_Gate_Script;

    // Start is called before the first frame update
    void Start()
    {
        Visual_Gate_Script = GetComponent<Visual_Gate_Script>();
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
        if (collider.gameObject.tag == "VolvoCar")
        {
            line.transform.position = Vector3.MoveTowards(line.transform.position, wayPoint2.transform.position, (Visual_Gate_Script.GetComponent<Visual_Gate_Script>().lineSpeed + 1f) * Time.deltaTime);
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "MineTruck")
        {
            line.transform.position = Vector3.MoveTowards(line.transform.position, wayPoint1.transform.position, Visual_Gate_Script.GetComponent<Visual_Gate_Script>().lineSpeed * Time.deltaTime);
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
