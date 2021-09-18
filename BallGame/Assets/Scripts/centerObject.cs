using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class centerObject : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        
        gameObject.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2f, Screen.height / 1.5f, Camera.main.nearClipPlane+20));

    }


}

