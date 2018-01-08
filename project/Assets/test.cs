//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class test : MonoBehaviour {
//    public static test instance;
//    // Use this for initialization
//    void Start () {
//        instance = this;
//    }
//    bool start = false;
//    public Texture2D MaskTex;
//    // Update is called once per frame
//    void Update () {
//        if (start)
//        {
//            start = false;
//            SaveTexture();
//        }
//    }

//    public void SaveTexture()
//    {
//        var path = AssetDatabase.GetAssetPath(MaskTex);
//        var bytes = MaskTex.EncodeToPNG();
//        File.WriteAllBytes(path, bytes);
//        AssetDatabase.ImportAsset(path, ImportAssetOptions.ForceUpdate);//刷新

//        UnityEngine.Debug.Log("SaveTexture");
//    }
//}
