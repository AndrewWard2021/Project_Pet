using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int weekCount;
    private int yearCount;
    void Start()
    {
        weekCount = 0;
        yearCount = 0;
    }
    // Update is called once per frame
    void Update()
    {
        //feed weekcount to display
    }

    public void NextWeek()
    {
        weekCount+=1;
        if (weekCount>=52)
        {
            weekCount = weekCount%52;
            yearCount+=1;
        }
    }
}
