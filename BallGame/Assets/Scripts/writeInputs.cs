using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class writeInputs : MonoBehaviour
{
    public TextMeshProUGUI[] textos = new TextMeshProUGUI[12];
    int detectEnd;

    private void Update()
    {
        deletenumberBack();
    }


    public void writeNumbers()
    {
        for(int i=0; i <= textos.Length; i++)
        {
            if(Buttons.movPlayer==1&& textos[i].text == "")
            {
                textos[i].text = "S";
                break;            
            }
           else if (Buttons.movPlayer == 2 && textos[i].text == "")
            {
                textos[i].text = "E";
                break;
            }
            else if (Buttons.movPlayer == 3 && textos[i].text == "")
            {
                textos[i].text = "W";
                break;
            }
            else  if (Buttons.movPlayer == 4 && textos[i].text == "")
            {
                textos[i].text = "N";
                break;
            }
        }


    }
    public void deletenumbers()
    {
        StartCoroutine(deleteNumbers());
    }

    IEnumerator deleteNumbers()
    {
        for (int i = 0; i <= textos.Length; i++)
        {
            if (textos[i].text!="")
            {
                textos[i].text = "";
                yield return new WaitForSeconds(0.5f);

            }
        }

    }

    public void deletenumberBack()
    {
        if (SaveInputs.deleteMovs)
        {
           for (int i = textos.Length-1; i >= textos.Length; i--)
            {
                if (textos[i].text != "")
                {
                    Debug.Log("si");
                    textos[i].text = "";
                    break;
                }
            }
        }
    }

}
