using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SaveInputs : MonoBehaviour
{
    public static List<int> Inputs = new List<int>();
    public static int backMov;
   public static bool deleteMovs = false;
    public Image num1;
    public Image num2;
    public Image num3;
    public Image num4;


    private void Update()
    {
        movements();
        
    }

    void movements()
    {
        if (Buttons.movPlayer == 1 && ButtonsLIST.movLeft1>0)
        {
            num1.color = new Color(num1.color.r - 0.25f, num1.color.g - 0.25f, num1.color.b - 0.25f);
            Inputs.Add(Buttons.movPlayer);
            Buttons.movPlayer = 0;
        }
        else if (Buttons.movPlayer == 2 && ButtonsLIST.movLeft2 > 0)
        {
            num2.color = new Color(num2.color.r - 0.25f, num2.color.g - 0.25f, num2.color.b - 0.25f);

            Inputs.Add(Buttons.movPlayer);

            Buttons.movPlayer = 0;


        }
        else if (Buttons.movPlayer == 3 && ButtonsLIST.movLeft3 > 0)
        {
            num3.color = new Color(num3.color.r - 0.25f, num3.color.g - 0.25f, num3.color.b - 0.25f);

            Inputs.Add(Buttons.movPlayer);

            Buttons.movPlayer = 0;




        }
        else if (Buttons.movPlayer == 4 && ButtonsLIST.movLeft4 > 0)
        {
            num4.color = new Color(num4.color.r - 0.25f, num4.color.g - 0.25f, num4.color.b - 0.25f);

            Inputs.Add(Buttons.movPlayer);


            Buttons.movPlayer = 0;

        }
    }

   public void resetMov()
    {
        deleteMovs = true;
         
    }

    public void deleteList()
    {
        for(int i = Inputs.Count; i > 0; i--)
        {
            Debug.Log("si");
            Inputs.RemoveAt(i);
        }
    }

}
