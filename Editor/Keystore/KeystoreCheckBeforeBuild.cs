using UnityEditor;
using UnityEngine;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using System.IO;

public class KeystoreCheckBeforeBuild : IPreprocessBuildWithReport
{
    public int callbackOrder => 0; // ���ȼ���ԽСԽ��ִ��

    public void OnPreprocessBuild(BuildReport report)
    {
        if (EditorUserBuildSettings.activeBuildTarget != BuildTarget.Android)
        {
            return; // �� Android ƽ̨������
        }

        if (!PlayerSettings.Android.useCustomKeystore)
        {
            throw new BuildFailedException("! Android ���ǩ��δ���ã�useCustomKeystore Ϊ false��");
        }

        if (string.IsNullOrEmpty(PlayerSettings.Android.keystoreName) ||
            !File.Exists(PlayerSettings.Android.keystoreName))
        {
            throw new BuildFailedException("! δ������Ч�� Keystore �ļ�·�����ļ�������");
        }

        if (string.IsNullOrEmpty(PlayerSettings.Android.keystorePass))
        {
            throw new BuildFailedException("! Keystore ����δ����");
        }

        if (string.IsNullOrEmpty(PlayerSettings.Android.keyaliasName))
        {
            throw new BuildFailedException("! Key Alias��������δ����");
        }

        if (string.IsNullOrEmpty(PlayerSettings.Android.keyaliasPass))
        {
            throw new BuildFailedException("! Key Alias ����δ����");
        }

        Debug.Log(" [ǩ�����ͨ��] Android ���ǩ�������걸");
    }
}
