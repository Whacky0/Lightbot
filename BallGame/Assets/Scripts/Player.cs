using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Stack<Vector3> pos = new Stack<Vector3>();
    Stack<Quaternion> Rotation = new Stack<Quaternion>();
   public static Stack<int> lastnum = new Stack<int>();
    public GameObject play;
    public GameObject back;

   
    // Update is called once per frame
    void Update()
    {
        backwardMov();

    }


    public void StartCorutine()
    {

        StartCoroutine(movPlayerForward());



    }

    IEnumerator movPlayerForward()
    {
        if (Play.play && SaveInputs.Inputs.Count > 0)
        {
            //desactivate During Runtime
            var buttons = GameObject.FindGameObjectsWithTag("Buttons");
            var compass = GameObject.FindGameObjectWithTag("Compass");
            foreach (var button in buttons)
            {
                button.SetActive(false);
            }
            var cross = GameObject.FindGameObjectWithTag("Cross");
            cross.SetActive(false);
            back.SetActive(false);
            play.SetActive(false);
            compass.SetActive(false);

            for (int i =0 ; i < SaveInputs.Inputs.Count; i++)
            {
                if (SaveInputs.Inputs[i] == 1)
                {
                    lastnum.Push(1);
                    //saveLastPos
                    pos.Push(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z));
                    Rotation.Push(Quaternion.Euler(gameObject.transform.rotation.eulerAngles.x, gameObject.transform.rotation.eulerAngles.y, gameObject.transform.rotation.eulerAngles.z));

                    gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z - 1);
                    gameObject.transform.Rotate(gameObject.transform.localRotation.x - 90, gameObject.transform.localRotation.y, gameObject.transform.localRotation.z, Space.World);
                    yield return new WaitForSeconds(0.5f);

                }
                else if (SaveInputs.Inputs[i] == 2)
                {
                    //saveLastPos
                    lastnum.Push(2);
                    pos.Push(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z));
                    Rotation.Push(Quaternion.Euler(gameObject.transform.rotation.eulerAngles.x, gameObject.transform.rotation.eulerAngles.y, gameObject.transform.rotation.eulerAngles.z));

                    gameObject.transform.position = new Vector3(gameObject.transform.position.x + 1, gameObject.transform.position.y, gameObject.transform.position.z);
                    gameObject.transform.Rotate(gameObject.transform.localRotation.x, gameObject.transform.localRotation.y, gameObject.transform.localRotation.z - 90, Space.World);
                    yield return new WaitForSeconds(0.5f);
                }

                else if (SaveInputs.Inputs[i] == 3)
                {
                    //saveLastPos
                    lastnum.Push(3);
                    pos.Push(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z));
                    Rotation.Push(Quaternion.Euler(gameObject.transform.rotation.eulerAngles.x, gameObject.transform.rotation.eulerAngles.y, gameObject.transform.rotation.eulerAngles.z));

                    gameObject.transform.position = new Vector3(gameObject.transform.position.x - 1, gameObject.transform.position.y, gameObject.transform.position.z);
                    gameObject.transform.Rotate(gameObject.transform.localRotation.x, gameObject.transform.localRotation.y, gameObject.transform.localRotation.z + 90, Space.World);
                    yield return new WaitForSeconds(0.5f);
                }
                else if (SaveInputs.Inputs[i] == 4)
                {
                    //saveLastPos
                    lastnum.Push(4);
                    pos.Push(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z));
                    Rotation.Push(Quaternion.Euler(gameObject.transform.rotation.eulerAngles.x, gameObject.transform.rotation.eulerAngles.y, gameObject.transform.rotation.eulerAngles.z));

                    gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + 1);
                    gameObject.transform.Rotate(gameObject.transform.localRotation.x + 90, gameObject.transform.localRotation.y, gameObject.transform.localRotation.z, Space.World);
                    yield return new WaitForSeconds(0.5f);

                }

            }
            Play.play = false;
            play.SetActive(true);
            back.SetActive(true);
            foreach (var button in buttons)
            {
                button.SetActive(true);
            }
            cross.SetActive(true);
            compass.SetActive(true);

            SaveInputs.Inputs.Clear();


        }

    }
    void backwardMov()
    {
        if (SaveInputs.deleteMovs)
        {
            if (pos.Count>0&& Rotation.Count > 0) {
            gameObject.transform.position = pos.Pop();
            gameObject.transform.rotation = Rotation.Pop();
            }

            SaveInputs.deleteMovs = false;
        }
    }

}
