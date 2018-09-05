﻿using System;
using System.Collections;
using System.Collections.Generic;
using Client.Data;
using UnityEngine;

namespace Client.ResourceModule
{
	public enum eLoadStatus
	{
		idle,
		Loading,
		Loaded,
		Release
	}
	public interface IAssetAsynResquest
	{
		T GetAsset<T>() where T:UnityEngine.Object; 
	}

	public interface IAssetLoader
	{
		string AssetName{get;}
		eLoadStatus Status{get;}
		int RefCount{get;}
		void Init(string assetName);
		UnityEngine.Object Load();
		T Load<T>() where T:UnityEngine.Object; 
		void LoadAsyn<T>(Action<T> onCacheFinished) where T:UnityEngine.Object;
		IAssetAsynResquest LoadAsyn();
		void Recycle();
	} 
}
