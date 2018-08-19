﻿using System.Collections;
using System.Collections.Generic;
using Client.Data;
using UnityEngine;

namespace Client.ResourceModule
{
    public class AssetBundleLoader : RecyclableObject,IAssetLoader<AssetBundle>
    {
        public static string CLASS_KEY="AssetBundleLoader";
        public override string ClassKey {get{return CLASS_KEY;}}

        public AssetBundle Aesset {get{return asset as AssetBundle;}}
        private Object IAssetLoader.Aesset {get{return asset;}}
        private Object asset;

        public float Progress{get{return progress;}}
        public float progress;

        public bool Compeleted{get{return compeleted;}}
        private bool compeleted;
		
        public eLoadError Error {get{return error;}}
        private eLoadError error = eLoadError.None;

        public AssetBundleLoader():base()
        {
            Init();
        }
        public void Init()
        {
            throw new System.NotImplementedException();
        }
    }
}
