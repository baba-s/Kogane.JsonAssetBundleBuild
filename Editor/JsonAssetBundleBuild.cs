using System;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

// ReSharper disable InconsistentNaming

namespace MyProject
{
    [Serializable]
    public struct JsonAssetBundleBuild
    {
        [SerializeField][UsedImplicitly] private string   assetBundleName;
        [SerializeField][UsedImplicitly] private string   assetBundleVariant;
        [SerializeField][UsedImplicitly] private string[] assetNames;
        [SerializeField][UsedImplicitly] private string[] addressableNames;

        public JsonAssetBundleBuild( AssetBundleBuild build )
        {
            assetBundleName    = build.assetBundleName;
            assetBundleVariant = build.assetBundleVariant;
            assetNames         = build.assetNames;
            addressableNames   = build.addressableNames;
        }

        public override string ToString()
        {
            return JsonUtility.ToJson( this, true );
        }
    }
}