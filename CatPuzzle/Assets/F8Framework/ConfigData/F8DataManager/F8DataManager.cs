﻿/*
 *   This file was generated by a tool.
 *   Do not edit it, otherwise the changes will be overwritten.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using F8Framework.Core;
using UnityEngine.Scripting;

namespace F8Framework.F8ExcelDataClass
{
	public class F8DataManager : ModuleSingleton<F8DataManager>, IModule
	{
		private Sheet1 p_Sheet1;
		private Sheet2 p_Sheet2;
		private LocalizedStrings p_LocalizedStrings;

		[Preserve]
		public Sheet1Item GetSheet1ByID(int id)
		{
			Sheet1Item t = null;
			p_Sheet1.Dict.TryGetValue(id, out t);
			if (t == null) LogF8.LogError("找不到id： " + id + " ，配置表： Sheet1");
			return t;
		}

		[Preserve]
		public Dictionary<int, Sheet1Item> GetSheet1()
		{
			return p_Sheet1.Dict;
		}

		[Preserve]
		public Sheet2Item GetSheet2ByID(int id)
		{
			Sheet2Item t = null;
			p_Sheet2.Dict.TryGetValue(id, out t);
			if (t == null) LogF8.LogError("找不到id： " + id + " ，配置表： Sheet2");
			return t;
		}

		[Preserve]
		public Dictionary<int, Sheet2Item> GetSheet2()
		{
			return p_Sheet2.Dict;
		}

		[Preserve]
		public LocalizedStringsItem GetLocalizedStringsByID(int id)
		{
			LocalizedStringsItem t = null;
			p_LocalizedStrings.Dict.TryGetValue(id, out t);
			if (t == null) LogF8.LogError("找不到id： " + id + " ，配置表： LocalizedStrings");
			return t;
		}

		[Preserve]
		public Dictionary<int, LocalizedStringsItem> GetLocalizedStrings()
		{
			return p_LocalizedStrings.Dict;
		}

		[Preserve]
		public void LoadLocalizedStrings()
		{
			p_LocalizedStrings = Load<LocalizedStrings>("LocalizedStrings") as LocalizedStrings;
		}

		[Preserve]
		public void LoadLocalizedStringsCallback(Action onLoadComplete)
		{
			Util.Unity.StartCoroutine(LoadLocalizedStringsIEnumerator(onLoadComplete));
		}

		[Preserve]
		public IEnumerator LoadLocalizedStringsIEnumerator(Action onLoadComplete = null)
		{
			yield return LoadAsync<LocalizedStrings>("LocalizedStrings", result => p_LocalizedStrings = result as LocalizedStrings);
			onLoadComplete?.Invoke();
		}

		[Preserve]
		public void LoadAll()
		{
			p_Sheet1 = Load<Sheet1>("Sheet1") as Sheet1;
			p_Sheet2 = Load<Sheet2>("Sheet2") as Sheet2;
			p_LocalizedStrings = Load<LocalizedStrings>("LocalizedStrings") as LocalizedStrings;
		}

		[Preserve]
		public void RuntimeLoadAll(Dictionary<String, System.Object> objs)
		{
			p_Sheet1 = objs["Sheet1"] as Sheet1;
			p_Sheet2 = objs["Sheet2"] as Sheet2;
			p_LocalizedStrings = objs["LocalizedStrings"] as LocalizedStrings;
		}

		[Preserve]
		public IEnumerable LoadAllAsync()
		{
			yield return LoadAsync<Sheet1>("Sheet1", result => p_Sheet1 = result as Sheet1);
			yield return LoadAsync<Sheet2>("Sheet2", result => p_Sheet2 = result as Sheet2);
			yield return LoadAsync<LocalizedStrings>("LocalizedStrings", result => p_LocalizedStrings = result as LocalizedStrings);
		}

		[Preserve]
		public void LoadAllAsyncCallback(Action onLoadComplete)
		{
			Util.Unity.StartCoroutine(LoadAllAsyncIEnumerator(onLoadComplete));
		}

		[Preserve]
		public IEnumerator LoadAllAsyncIEnumerator(Action onLoadComplete)
		{
			yield return LoadAsync<Sheet1>("Sheet1", result => p_Sheet1 = result as Sheet1);
			yield return LoadAsync<Sheet2>("Sheet2", result => p_Sheet2 = result as Sheet2);
			yield return LoadAsync<LocalizedStrings>("LocalizedStrings", result => p_LocalizedStrings = result as LocalizedStrings);
			onLoadComplete?.Invoke();
		}

		[Preserve]
		public T Load<T>(string name)
		{
			IFormatter f = new BinaryFormatter();
			TextAsset textAsset = AssetManager.Instance.Load<TextAsset>(name);
			if (textAsset == null)
			{
				return default(T);
			}
			AssetManager.Instance.Unload(name, false);
			using (MemoryStream memoryStream = new MemoryStream(textAsset.bytes))
			{
				return (T)f.Deserialize(memoryStream);
			}
		}

		[Preserve]
		public IEnumerator LoadAsync<T>(string name, Action<T> callback)
		{
			IFormatter f = new BinaryFormatter();
			var load = AssetManager.Instance.LoadAsyncCoroutine<TextAsset>(name);
			yield return load;
			TextAsset textAsset = AssetManager.Instance.GetAssetObject<TextAsset>(name);
			if (textAsset != null)
			{
				AssetManager.Instance.Unload(name, false);
#if UNITY_WEBGL
				T obj = Util.LitJson.ToObject<T>(textAsset.text);
				callback(obj);
#else
				using (Stream s = new MemoryStream(textAsset.bytes))
				{
					T obj = (T)f.Deserialize(s);
					callback(obj);
				}
#endif
			}
		}

		public void OnInit(object createParam)
		{
			
		}

		public void OnUpdate()
		{
			
		}

		public void OnLateUpdate()
		{
			
		}

		public void OnFixedUpdate()
		{
			
		}

		public void OnTermination()
		{
			base.Destroy();
		}
	}
}