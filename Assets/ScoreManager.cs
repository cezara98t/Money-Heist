using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreManager : MonoBehaviour
{
    public static int score = 0;
    private string text;
    private GUIStyle style = new GUIStyle();

   
    public static void add()
    {
        score++;
    }
    private void Update()
    {
        text = "Score: " + score;
    }
    public static void restart()
    {
        score = 0;
    }

    private void OnGUI()
    {
        style.fontSize = 30;
        GUI.Label(new Rect(10, 10, 100, 50), text, style);
    }
}
