using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class LogSpam
{
    [MenuItem("LogSpam/Log")]
    public static void Log()
    {
        string path = "Assets/text1mb.txt";
        string text = File.ReadAllText(path);
        for (int i = 0; i < 16; i++)
        {
            Debug.Log(text);
        }
    }
}
