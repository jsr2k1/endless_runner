using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonsScript : MonoBehaviour
{
	public Image imagePause;

	public void OnPlayButtonPressed()
	{
		Application.LoadLevel("01 MainScene");
	}

	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	public void OnRetryButtonPressed()
	{
		Application.LoadLevel("01 MainScene");
	}
	
	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	
	public void OnPauseButtonPressed()
	{
		GameManager.instance.state = GameManager.States.PAUSE;	
		imagePause.GetComponent<Animator>().SetTrigger("ShowWindow");
	}
	
	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	
	public void OnContinueButtonPressed()
	{
		GameManager.instance.state = GameManager.States.RUN;
		imagePause.GetComponent<Animator>().SetTrigger("HideWindow");
	}
	
	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	
	public void OnExitButtonPressed()
	{
		Application.LoadLevel("00 Menu");
	}
}
