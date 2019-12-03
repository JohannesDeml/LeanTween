// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LeanTweenEditorUtils.cs" company="Supyrb">
//   Copyright (c)  Supyrb. All rights reserved.
// </copyright>
// <author>
//   Johannes Deml
//   send@johannesdeml.com
// </author>
// --------------------------------------------------------------------------------------------------------------------

using UnityEditor;

public static class LeanTweenEditorUtils
{
	[InitializeOnLoadMethod]
	static void OnProjectLoadedInEditor()
	{ 
		EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
	}

	/// <summary>
	/// Reset leantween when exiting the play mode
	/// This way Leantween does not require to reload the domain or scene when entering the playmode (available since 2019.3)
	/// </summary>
	/// <param name="state"></param>
	private static void OnPlayModeStateChanged(PlayModeStateChange state)
	{
		if (state == PlayModeStateChange.EnteredEditMode)
		{
			LeanTween.reset();
		}
	}
}