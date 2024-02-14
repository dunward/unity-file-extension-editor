using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEditor.AssetImporters;
using UnityEngine;
using UnityEngine.UI;

[ScriptedImporter(1, new[] { "local1", "local2", "sample1" })]
public class LocalizationFileImporter : ScriptedImporter
{
    public override void OnImportAsset(AssetImportContext ctx)
    {
        var formatter = new BinaryFormatter();
        Stream stream = new FileStream(ctx.assetPath, FileMode.Open, FileAccess.Read, FileShare.Read);
        var localizationData = formatter.Deserialize(stream) as List<LocalizationData>;
        stream.Close();

        foreach (var data in localizationData)
        {
            var textAsset = new TextAsset(data.text);
            textAsset.name = data.countryCode;
            ctx.AddObjectToAsset(data.countryCode, textAsset);
        }
    }
}