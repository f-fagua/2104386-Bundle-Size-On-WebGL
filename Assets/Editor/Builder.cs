using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class Builder : MonoBehaviour
{
    [MenuItem("Unity Support/Build Android")]
    public static void BuildAndroid()
    {
        string outputPath = Path.Combine(Application.streamingAssetsPath, "Android");
        if (!Directory.Exists(outputPath))
            Directory.CreateDirectory(outputPath);
        
        BuildBundles(outputPath, BuildTarget.Android);
    }

    [MenuItem("Unity Support/Build WebGL")]
    public static void BuildWebGL()
    {
        string outputPath = Path.Combine(Application.streamingAssetsPath, "WebGL");
        if (!Directory.Exists(outputPath))
            Directory.CreateDirectory(outputPath);
        BuildBundles(outputPath, BuildTarget.WebGL);
    }

    public static void BuildBundles(string outputPath, BuildTarget targetPlatform)
    {
        BuildPipeline.BuildAssetBundles(outputPath, BuildAssetBundleOptions.None, targetPlatform);
    }
}
