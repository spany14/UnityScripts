using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDelay : MonoBehaviour
{
    [SerializeField]
    float interval = 5f;

    float timeHolder;
    
    // Start is called before the first frame update
    void Start()
    {
        timeHolder = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        timeHolder += Time.deltaTime;
        
        while (timeHolder >= interval) 
        {
            
            DebugText();
            timeHolder -= interval;
        }
        
    }


    void DebugText()
    {
        Debug.Log(" 5 seconds passed  " + System.DateTime.Now);
    }
}
