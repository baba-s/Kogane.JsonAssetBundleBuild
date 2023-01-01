using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

// ReSharper disable InconsistentNaming

namespace Kogane
{
    [Serializable]
    public struct JsonAssetBundleBuilds
    {
        [SerializeField][UsedImplicitly] private JsonAssetBundleBuild[] builds;

        public JsonAssetBundleBuilds( IReadOnlyList<AssetBundleBuild> builds )
        {
            this.builds = builds
                    .Select( x => new JsonAssetBundleBuild( x ) )
                    .ToArray()
                ;
        }

        public override string ToString()
        {
            return JsonUtility.ToJson( this, true );
        }
    }
}