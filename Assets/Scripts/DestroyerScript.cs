using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DestroyerScript : MonoBehaviour
{
	public delegate void GameOverEvent();
	public static event GameOverEvent OnGameOverEvent;

	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player"){
			GameManager.instance.state = GameManager.States.GAMEOVER;
			if(OnGameOverEvent!=null){
				OnGameOverEvent();
			}
			return;
		}
		if(other.gameObject.transform.parent){
			Destroy(other.gameObject.transform.parent.gameObject);
		}else{
			Destroy(other.gameObject);
		}
	}
}
