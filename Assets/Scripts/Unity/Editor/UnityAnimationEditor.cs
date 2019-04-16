﻿using UnityEditor;
using UbiArt;
using UnityEngine;
using System.Linq;

[CustomEditor(typeof(UnityAnimation))]
public class UnityAnimationEditor : Editor {

	public override void OnInspectorGUI() {
		DrawDefaultInspector();

		UnityAnimation ua = target as UnityAnimation;
		if (ua != null && ua.anims != null) {
			int ind = ua.animTrack == null ? -1 : ua.anims.FindIndex(a => a.Item2 == ua.animTrack);
			int newInd = EditorGUILayout.Popup("Animations", ind, ua.anims.Select(a => a.Item1.filename).ToArray());
			GUILayout.BeginHorizontal();
			GUI.enabled = newInd > 0;
			if (GUILayout.Button("Previous")) newInd--;
			GUI.enabled = (newInd < ua.anims.Count - 1);
			if (GUILayout.Button("Next")) newInd++;
			GUI.enabled = true;
			GUILayout.EndHorizontal();
			if (ind != newInd) {
				ua.animTrack = ua.anims[newInd].Item2;
				ua.Init();
			}
		}

	}
}