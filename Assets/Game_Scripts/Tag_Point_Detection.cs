using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tag_Point_Detection : MonoBehaviour
{
    public GameObject mineTruck;
    public float timeLeft;
    public float timerReset = 3f;
    public TMP_Text timerText;
    public bool timeYes;

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

        if (timeYes == true)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
            }
            else
            {
                timeLeft = 0;
            }

            Timer(timeLeft);            
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "MineTruck" || collider.gameObject.tag == "VolvoCar")
        {
            timeYes = true;
        }
    }

    void Timer(float timerDisplay)
    {
        if (timerDisplay < 0)
        {
            timerDisplay = 0;
        }

        float timeInMins = Mathf.FloorToInt(timerDisplay / 60);
        float timeInSecs = Mathf.FloorToInt(timerDisplay % 60);

        timerText.text = string.Format("{0}", timeInSecs);
    }

    void TruckInScene()
    {
        if(mineTruck == null)
        {
            Destroy(this.gameObject);
        }
    }
}
