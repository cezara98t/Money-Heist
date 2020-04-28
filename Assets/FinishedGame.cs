using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinishedGame : MonoBehaviour
{
    public string finishText;
    private GUIStyle style= new GUIStyle();

    private void OnCollisionEnter(Collision collision)
    {
        style.fontSize = 30;
        gameObject.GetComponent<BoxCollider>().isTrigger = true;
        if (ScoreManager.score == 14)
            finishText = "You've collected all the coins!\n Press R to restart!";
        else
            finishText = "You didn't collect all the coins!\n Press R to restart!";

        
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 50, 100, 300), finishText, style);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ScoreManager.restart();
            Application.LoadLevel(0);
        }
    }
}

    

