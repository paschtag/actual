using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using UnityEngine.UI;
public class WriteScript : MonoBehaviour
{
    public void WriteString()
    {
        string path = "Assets/scores.txt";

        string Name = KeepData.PlayerName;
        string score = KeepData.PlayerScore.ToString();


       
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(Name + ", " + score);
        writer.Close();

      
        AssetDatabase.ImportAsset(path);
        TextAsset asset = (TextAsset)Resources.Load("Scores"); 
    }
}
