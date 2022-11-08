using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Player : MonoBehaviour
{
    public AudioSource audioSource, audioSource2;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        if(audioSource != null) audioSource.Play();
        InvokeRepeating("PlaySound",1.00f,0.7f);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void PlaySound()
    {
        if(audioSource2 != null) audioSource2.Play();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "MineTruck")
        {
            CancelInvoke();
            InvokeRepeating("PlaySound", 0.001f, 0.2f);
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "MineTruck")
        {
            CancelInvoke();
            InvokeRepeating("PlaySound", 0.001f, 0.5f);
        }
    }
}
