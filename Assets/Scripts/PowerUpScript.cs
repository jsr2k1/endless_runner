using UnityEngine;
using System.Collections;

public class PowerUpScript : MonoBehaviour
{
	UIManager hud;

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player"){
			hud = GameObject.Find("Main Camera").GetComponent<UIManager>(); //TODO: Not efficient!
			hud.IncreaseScore(10);
			Destroy(this.gameObject);
		}
	}
}
