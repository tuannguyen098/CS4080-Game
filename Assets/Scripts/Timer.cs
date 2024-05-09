using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Timer : MonoBehaviour
{
    private float timer;
    private bool isRunning = true;
    public TMP_Text currenttime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isRunning)
        {
            timer += Time.deltaTime;
            currenttime.text = "Timer: " + timer.ToString("F2"); // Format to 2 decimal places
        }
    }

    public void StopTimer()
    {
        isRunning = false;
    }
}
