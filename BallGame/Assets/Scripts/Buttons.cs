using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public static int movPlayer;

    public void Mov1()
    {
        if (ButtonsLIST.movLeft1 > 0) { 
        movPlayer = 1;
        }
    }
    public void Mov2()
    {
        if (ButtonsLIST.movLeft2 > 0)
            movPlayer = 2;

    }
    public void Mov3()
    {
        if (ButtonsLIST.movLeft3 > 0)
            movPlayer = 3;

    }
    public void Mov4()
    {
        if (ButtonsLIST.movLeft4 > 0)
            movPlayer = 4;

    }
}
