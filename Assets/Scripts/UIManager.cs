﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
	int playerScore = 0;
	int highScore;
	float tmpScore;

	public Text scoreText;
	public Text scoreTextGameOver;
	public Text highScoreTextGameOver;

	public Animator popUpPause;
	public Animator popUpGameOver;

	public static UIManager instance;
	
	///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	void Awake()
	{
		instance = this;
	}

	///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	void OnEnable()
	{
		DestroyerScript.OnGameOverEvent += OnGameOver;
	}
	
	///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	
	void OnDisable()
	{
		DestroyerScript.OnGameOverEvent -= OnGameOver;
	}

	///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	void OnGameOver()
	{
		saveHighScore();
		scoreTextGameOver.text = scoreText.text;
		highScoreTextGameOver.text = highScore.ToString("00000");
		popUpGameOver.SetTrigger("ShowWindow");
	}

	///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	void Update()
	{
		if(GameManager.instance.state == GameManager.States.RUN){
			tmpScore += Time.deltaTime;
			playerScore = (int)(tmpScore*10);
			scoreText.text = playerScore.ToString("00000");
		}
	}

	///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	//PowerUps
	public void IncreaseScore(int amount)
	{
		//playerScore += amount;
	}

	///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	void saveHighScore()
	{
		//PlayerPrefs.SetInt("Score", (int)(playerScore));

		if(PlayerPrefs.HasKey("HighScore")){
			highScore = PlayerPrefs.GetInt("HighScore");
			if(highScore < playerScore){
				PlayerPrefs.SetInt("HighScore", (int)(playerScore));
				highScore = playerScore;
			}
		}else{
			PlayerPrefs.SetInt("HighScore", (int)(playerScore));
			highScore = playerScore;
		}
	}
	
	///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	
	public void OnRetryButtonPressed()
	{
		Application.LoadLevel("01 MainScene");
	}
	
	///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	
	public void OnPauseButtonPressed()
	{
		GameManager.instance.state = GameManager.States.PAUSE;
		popUpPause.SetTrigger("ShowWindow");
	}
	
	///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	
	public void OnContinueButtonPressed()
	{
		GameManager.instance.state = GameManager.States.RUN;
		popUpPause.SetTrigger("HideWindow");
	}
	
	///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	
	public void OnExitButtonPressed()
	{
		Application.LoadLevel("00 Menu");
	}
}





