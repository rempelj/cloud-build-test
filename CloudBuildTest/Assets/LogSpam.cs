using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif


public class LogSpam
{
    
    #if UNITY_EDITOR
    [MenuItem("LogSpam/Log")]
    #endif
    public static void Log()
    {
        string path = "Assets/text1mb.txt";
        string text = File.ReadAllText(path);
        for (int i = 0; i < 135; i++)
        {
            Debug.Log(text);
        }
    }
}
