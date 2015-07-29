using UnityEngine;
using System.Collections;

public class UIManagerMap : MonoBehaviour
{
	public void OnButtonBackPressed()
	{
		Application.LoadLevel("00 Menu");
	}
}
