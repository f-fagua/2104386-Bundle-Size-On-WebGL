using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AudioSetter : MonoBehaviour
{
    [MenuItem("Unity Support/Set Low")]
    public static void SetAudioFrequencyLow()
    {
        string assetPath = AssetDatabase.GetAssetPath(Selection.activeObject);
        SetAudioFrequency(assetPath, 12000);
    }
    
    [MenuItem("Unity Support/Set High")]
    public static void SetAudioFrequencyHigh()
    {
        string assetPath = AssetDatabase.GetAssetPath(Selection.activeObject);
        SetAudioFrequency(assetPath, 48000);
    }

    public static void SetAudioFrequency(string audioPath, int frequency)
    {
        AudioClip audioClip = AssetDatabase.LoadAssetAtPath<AudioClip>(audioPath);
        SerializedObject audioClipSO = new SerializedObject(audioClip);

        SerializedProperty frecuency = audioClipSO.FindProperty("m_Frequency");
        frecuency.intValue = frequency;

        audioClipSO.ApplyModifiedProperties();
    }
}
