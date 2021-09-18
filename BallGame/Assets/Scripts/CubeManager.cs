using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeManager : MonoBehaviour
{
    public Image num1;
    public Image num2;
    public Image num3;
    public Image num4;
    // Update is called once per frame
    void Update()
    {
        var start = GameObject.Find("Start");

        var Player = GameObject.FindGameObjectWithTag("Player");

        if (Player.transform.position.y <= -15)
        {
            StartCoroutine(sceneLoader.reset());
            num1.color = new Color(1, 1, 1);
            num2.color = new Color(1, 1, 1);
            num3.color = new Color(1, 1, 1);
            num4.color = new Color(1, 1, 1);

            SaveInputs.Inputs.Clear();
            Player.transform.position = new Vector3(start.transform.position.x, start.transform.position.y + 20,start.transform.position.z);
            Player.transform.rotation=Quaternion.identity;
        }
    }
}
