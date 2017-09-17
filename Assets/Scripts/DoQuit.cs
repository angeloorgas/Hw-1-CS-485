﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoQuit : MonoBehaviour {

	public void ExecuteQuit()
	{
		#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
		#else
			Application.Quit();
		#endif
	}
}
