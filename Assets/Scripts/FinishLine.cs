using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    private GUIStyle guiStyle = new GUIStyle();
    private bool displayMessage;
    private GUIStyle style = new GUIStyle();
    // Start is called before the first frame update
    void Start()
    {

        displayMessage = false;
        style.fontSize = 100;
        GUI.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Time.timeScale = 1.0f;
        }
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            Debug.Log("yahooo");
           displayMessage = true;
           Time.timeScale = 0f;
        }
    }
    void OnGUI()
    {
        if (displayMessage)
        {
            GUI.Label(new Rect(Screen.width / 2 - 125, Screen.height / 2 -50, 200f, 200f), "Finish", style);
        }

    }
}
