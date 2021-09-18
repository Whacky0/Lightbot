using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckColorWIn : MonoBehaviour
{
    public static bool keyWin;

    private void OnEnable()
    {
        keyWin = false;
    }
    private void Update()
    {
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (WinTrigger.Win)
        {

            Material color = gameObject.GetComponent<Renderer>().material;
            var player = GameObject.FindGameObjectWithTag("Player");
            Renderer keyMaterial = player.GetComponent<Renderer>();

            if (color.color == keyMaterial.material.color)
            {
                keyWin = true;
                Debug.Log("keywin");
            }

        }
    }
}
