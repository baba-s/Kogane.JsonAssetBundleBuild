# Kogane Json Asset Bundle Build

AssetBundleBuild 構造体を JSON 形式の文字列に変換できるパッケージ

## 使用例

```cs
using MyProject;
using UnityEditor;
using UnityEngine;

public static class Example
{
    public static void Hoge( AssetBundleBuild[] builds )
    {
        Debug.Log( new JsonAssetBundleBuilds( builds ) );

        BuildPipeline.BuildAssetBundles
        (
            outputPath: "AssetBundles/Android",
            builds: builds,
            assetBundleOptions: BuildAssetBundleOptions.None,
            targetPlatform: BuildTarget.Android
        );
    }
}
```