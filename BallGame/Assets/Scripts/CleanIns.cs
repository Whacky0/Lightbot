using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class CleanIns : MonoBehaviour
{
    float num1;
    float num2;
    float num3;
    float num4;

    private void OnEnable()
    {
        num1 = 0;
        num2 = 0;
        num3 = 0;
        num4 = 0;
    }
    public void CleanInputs()
    {
        foreach (var inputs in SaveInputs.Inputs)
        {
            if (inputs == 1)
            {
                num1 += 0.25f;
            }
           else if (inputs == 2)
            {
                num2 += 0.25f;
            }
          else  if (inputs == 3)
            {
                num3 += 0.25f;
            }
          else  if (inputs == 4)
            {
                num4 += 0.25f;
            }
        }
        SaveInputs.Inputs.Clear();
        var texts = GameObject.FindGameObjectsWithTag("Texts");
        foreach (var text in texts)
        {
           var numbers= text.GetComponent<TextMeshProUGUI>();
            numbers.text = "";
        }

        var buttons= GameObject.FindGameObjectsWithTag("Buttons");
       
        for(int i=0; i < buttons.Length; i++) { 
            
            if (num1 != 0) {
            Debug.Log(num1);
                var image = buttons[0].GetComponent<Image>();
                image.color = new Color(image.color.r+num1, image.color.g+num1,image.color.b+ num1);
            num1 = 0;
            }
            else if (num2 != 0)
            {
                var image = buttons[1].GetComponent<Image>();
                image.color = new Color(image.color.r+num2, image.color.g + num2, image.color.b + num2);
            num2= 0;

        }
       else if (num3 != 0)
            {
                var image = buttons[2].GetComponent<Image>();
                image.color = new Color(image.color.r+num3, image.color.g + num3, image.color.b + num3);
            num3 = 0;

        }
       else if (num4 != 0)
            {
                var image = buttons[3].GetComponent<Image>();

                image.color = new Color(image.color.r+num4, image.color.g + num4, image.color.b + num4);
            num4 = 0;


        }
        }


    }
}
