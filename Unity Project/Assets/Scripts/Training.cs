using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Training : MonoBehaviour
{
    public enum training {ect,str};
    public training type;

    public void Trained()
    {
        switch(type)
        {
            case training.ect:
                GameManager.instance.NextWeek();
                break;
        }
    }
}
