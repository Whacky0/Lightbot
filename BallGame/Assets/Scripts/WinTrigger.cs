using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public static bool Win;
    private void OnEnable()
    {
        Win = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Win = true;
            Debug.Log("Win");
        }
    }

    
   
}
