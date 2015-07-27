using UnityEngine;
using System.Collections;

public class UIManagerMenu : MonoBehaviour
{
	public void OnPlayButtonPressed()
	{
		Application.LoadLevel("01 Map");
	}
}
