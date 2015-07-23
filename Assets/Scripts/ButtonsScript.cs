using UnityEngine;
using System.Collections;

public class ButtonsScript : MonoBehaviour
{
	public void OnPlayButtonPressed()
	{
		Application.LoadLevel("01 MainScene");
	}

	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	public void OnRetryButtonPressed()
	{
		Application.LoadLevel("01 MainScene");
	}
}
