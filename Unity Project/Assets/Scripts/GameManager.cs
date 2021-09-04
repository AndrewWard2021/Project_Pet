using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    #region Variables
    private int weekCount;
    private int yearCount;
    public Text yearText;
    public Text weekText;
    #endregion
    #region Singleton
    public static GameManager instance;
    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More then one instance of game manager");
        }
        instance = this;
    }
    #endregion

    void Start()
    {
        weekCount = 0;
        yearCount = 1;
    }
    // Update is called once per frame
    void Update()
    {
        //feed weekcount to display
        weekText.text = "Week: "+weekCount;
        yearText.text = "Year: "+yearCount;
    }

    public void NextWeek()
    {
        weekCount+=1;
        if (weekCount>=53)
        {
            weekCount = weekCount%53;
            yearCount+=1;
        }
    }
}
