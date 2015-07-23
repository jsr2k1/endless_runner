using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreScript : MonoBehaviour
{
	public string id;

	void Start()
	{
		Text score = GetComponent<Text>();
		score.text = PlayerPrefs.GetInt(id).ToString();
	}
}
