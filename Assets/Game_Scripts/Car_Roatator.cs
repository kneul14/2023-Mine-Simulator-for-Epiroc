using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Car_Roatator : MonoBehaviour
{
    public float degreeToRotate;
    public GameObject volvoCar;
    public GameObject nextGameObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //volvoCar.transform.LookAt(transform.position);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "VolvoCar")
        {
            SmoothRoatate();
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "VolvoCar")
        {
            Debug.Log("corou");
            StopAllCoroutines();
        }
    }

    void SmoothRoatate()
    {
        if (volvoCar != null)
        {
            StartCoroutine(RotateCarSmoothly());
        }
    }

    IEnumerator RotateCarSmoothly()
    {
        float moveSpeed = 5f;
        while (volvoCar.transform.rotation.y < 180)
        {
            volvoCar.transform.rotation = Quaternion.Lerp(volvoCar.transform.rotation, Quaternion.Euler(0, degreeToRotate, 0), moveSpeed * Time.deltaTime);
            volvoCar.transform.position = new Vector3(volvoCar.transform.position.x, volvoCar.transform.position.y, volvoCar.transform.position.z);
            yield return null;
        }
        volvoCar.transform.rotation = Quaternion.Euler(0, degreeToRotate, 0);
        yield return null;
    }

    //IEnumerator PositionCarSmoothly()
    //{
    //    float moveSpeed = 5f;
    //    while (volvoCar.transform.rotation.y < 180)
    //    {
    //        yield return null;
    //    }
    //    volvoCar.transform.rotation = Quaternion.Euler(0, degreeToRotate, 0);
    //    yield return null;
    //}
}
