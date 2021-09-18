using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoader : MonoBehaviour
{
    public static sceneLoader instance;
   public static bool gano = false;
    private void Awake()
    {
        if (instance == null)
        {
           instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }


    }



    private void Update()
    {
        
        if (!gano) { 
        CheckWin();
        }
    }

    void CheckWin()
    {

            var winOb = GameObject.Find("Win");

            if (winOb.GetComponent("CheckColorWIn") == null && WinTrigger.Win)
            {
            SaveInputs.Inputs.Clear();
            StartCoroutine(animaion());
            gano = true;

            }
            else if (winOb.GetComponent("CheckColorWIn") != null && WinTrigger.Win && CheckColorWIn.keyWin)
        {
            SaveInputs.Inputs.Clear();
            StartCoroutine(animaion());
            gano = true;
        }
    }

    public void resetScene()
    {
        StartCoroutine(reset());
    }

    IEnumerator animaion()
    {
        var compass = GameObject.FindGameObjectWithTag("Compass");
        compass.SetActive(false);
        var anima = GameObject.Find("Transition");
        var anim = anima.GetComponent<Animator>();
        anim.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene + 1);
        Player.lastnum.Clear();
        KeepAnim.iniciarCin = true;
        gano = false;
        compass.SetActive(true);
    }
    public static IEnumerator reset()
    {
        var compass = GameObject.FindGameObjectWithTag("Compass");
        compass.SetActive(false);
        var anima = GameObject.Find("Transition");
        var anim = anima.GetComponent<Animator>();
        anim.SetTrigger("Start");
        yield return new WaitForSeconds(0.5f);
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
        Player.lastnum.Clear();
        KeepAnim.iniciarCin = true;
        gano = false;
        compass.SetActive(true);
    }
}
