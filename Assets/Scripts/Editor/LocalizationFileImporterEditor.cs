using UnityEditor;

using UnityEditor.SceneManagement;
using UnityEngine;

[CustomEditor(typeof(LocalizationFileImporter))]
public class LocalizationFileImporterEditor: UnityEditor.AssetImporters.ScriptedImporterEditor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
    }
}