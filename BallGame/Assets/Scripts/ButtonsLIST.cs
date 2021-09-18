using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsLIST : MonoBehaviour
{
    public Image num1;
    public Image num2;
    public Image num3;
    public Image num4;

    public static int movLeft1;
    public static int movLeft2;
    public static int movLeft3;
    public static int movLeft4;




    private void Update()
    {
        colonums();
    }


    void colonums()
    {
        //num1
        if (num1.color.r == 1)
        {
            movLeft1 = 4;
        }
        else if (num1.color.r==0.75)
        {
            movLeft1 = 3;
        }
        else if (num1.color.r == 0.50)
        {
            movLeft1 = 2;
        }
        else if (num1.color.r == 0.25)
        {
            movLeft1 = 1;
        }
        else if (num1.color.r == 0)
        {
            movLeft1 = 0;
        }
        //num2
        if (num2.color.r == 1)
        {
            movLeft2 = 4;
        }
        else if (num2.color.r == 0.75)
        {
            movLeft2 = 3;
        }
        else if (num2.color.r == 0.50)
        {
            movLeft2 = 2;
        }
        else if (num2.color.r == 0.25)
        {
            movLeft2 = 1;
        }
        else if (num2.color.r == 0)
        {
            movLeft2 = 0;
        }
        //num3
        if (num3.color.r == 1)
        {
            movLeft3 = 4;
        }
        else if (num3.color.r == 0.75)
        {
            movLeft3 = 3;
        }
        else if (num3.color.r == 0.50)
        {
            movLeft3 = 2;
        }
        else if (num3.color.r == 0.25)
        {
            movLeft3 = 1;
        }
        else if (num3.color.r == 0)
        {
            movLeft3 = 0;
        }
        //num4
        if (num4.color.r == 1)
        {
            movLeft4 = 4;
        }
        else if (num4.color.r == 0.75)
        {
            movLeft4 = 3;
        }
        else if (num4.color.r == 0.50)
        {
            movLeft4 = 2;
        }
        else if (num4.color.r == 0.25)
        {
            movLeft4 = 1;
        }
        else if (num4.color.r == 0)
        {
            movLeft4 = 0;
        }
    }
}
