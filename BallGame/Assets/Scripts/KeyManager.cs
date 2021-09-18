using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour
{

  
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Material metal = gameObject.GetComponent<Renderer>().material;
            var player = GameObject.FindGameObjectWithTag("Player");
            Renderer keyMaterial = player.GetComponent<Renderer>();
            keyMaterial.sharedMaterial = metal;


        }
    }
}
