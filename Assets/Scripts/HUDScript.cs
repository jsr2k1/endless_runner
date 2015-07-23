using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour
{
	int playerScore = 0;
	float tmpScore = 0;
	public Text scoreText;
	
	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	void Update()
	{
		tmpScore += Time.deltaTime;
		playerScore = (int)(tmpScore*10);
		scoreText.text = playerScore.ToString("000000");
	}

	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	//PowerUps
	public void IncreaseScore(int amount)
	{
		//playerScore += amount;
	}

	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	void OnDisable()
	{
		PlayerPrefs.SetInt("Score", (int)(playerScore));

		if(PlayerPrefs.HasKey("HighScore")){
			int highscore = PlayerPrefs.GetInt("HighScore");
			if(highscore < playerScore){
				PlayerPrefs.SetInt("HighScore", (int)(playerScore));
			}
		}else{
			PlayerPrefs.SetInt("HighScore", (int)(playerScore));
		}
	}
}
