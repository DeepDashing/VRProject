using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEditor;

public class MoveAsset : MonoBehaviour
{
        [MenuItem("AssetDatabase/FileOperationsExample")]
        void Start()
        {
            string ret;
            string hello;
            hello = "Hello, World!";
            // Move
            ret = AssetDatabase.MoveAsset(/*AssetDatabase.GetAssetPath(material)*/ "Assets/DefaultMaterial_Roughness.jpg", "Assets/Materials/DefaultMaterial_Roughness.jpg");
            if (ret == "")
                Debug.Log("GOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOAL!");
            else
                Debug.Log("Hello, Wooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooorld!");
    
    }


    
}