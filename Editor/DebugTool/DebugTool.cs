using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class DebugTool
{
    [MenuItem("Tools/DebugTool/����Ϊ������ģʽ")]
    public static void DebugModel()
    {
        try
        {
            MainRoot.Instance.model = MainRoot.Model.Debug;
            UnityEngine.Debug.Log("���л�Ϊ������ģʽ");
        }
        catch
        {
            UnityEngine.Debug.LogError("�л�������ģʽʧ�ܣ��������ã�");
        }
    }
    [MenuItem("Tools/DebugTool/����Ϊ����ģʽ")]
    public static void ReleaseModel()
    {
        try
        {
            MainRoot.Instance.model = MainRoot.Model.Release;
            UnityEngine.Debug.Log("���л�Ϊ����ģʽ");
        }
        catch
        {
            UnityEngine.Debug.LogError("�л�����ģʽʧ�ܣ��������ã�");
        }
    }
}
