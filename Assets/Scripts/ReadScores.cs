using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class ReadScores : MonoBehaviour
{
    public Text fileContents;

    private void Awake() 
    {
        string path = "Assets/scores.txt";

       

        fileContents.text = ""; 
       
        string[] readText = File.ReadAllLines(path);
        foreach (string s in readText)
        {
            Debug.Log(s);
            fileContents.text += s + "\n"; // append and go to new line
        }
    }

}
