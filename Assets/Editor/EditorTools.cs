using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.Collections;

class MyWindow : EditorWindow
{
	[MenuItem ("Custom/DeleteAllKeysPlayerPrefs")]
	public static void DeleteAllKeysPlayerPrefs()
	{
		PlayerPrefs.DeleteAll();
	}
}
