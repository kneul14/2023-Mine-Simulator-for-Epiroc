using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Colour_Changer_Car : MonoBehaviour
{
    Light carlight;

    // Start is called before the first frame update
    void Start()
    {
        carlight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        //carlight.color = Color.white;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "MineTruck")
        {
            carlight.color = Color.yellow;
            StartCoroutine("RedLight");
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "MineTruck")
        {
            carlight.color = Color.green;
            StopAllCoroutines();
        }
    }

    IEnumerator RedLight()
    {
        yield return new WaitForSeconds(1.25f);
        carlight.color = Color.red; 
    }
}
