using UnityEngine;
using System.Collections;

public class CameraRunnerScript : MonoBehaviour
{
	public Transform player;
	float dist;

	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	void Awake()
	{
		//La posicion de la camara depende un poco del ratio de pantalla
		//Si el ratio es 16/9 (1.777) --> la posicion debe ser + 6
		//Si el ratio es 4/3 (1.333) --> la posicion debe ser + 4
		float ratio = (float)Screen.width/(float)Screen.height;
		float value = Mathf.InverseLerp(1.777f, 1.333f, ratio);
		dist = Mathf.Lerp(6, 4, value);
	}

	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	void Update()
	{
		transform.position = new Vector3(player.position.x + dist, 0, -10);
	}
}
