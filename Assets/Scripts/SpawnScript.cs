using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour
{
	public GameObject[] obj;
	public int mult;
	public bool bRandomY;

	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	void Start()
	{
		StartCoroutine(Spawn());
	}

	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	IEnumerator Spawn()
	{
		while(GameManager.instance.state == GameManager.States.PAUSE){
			yield return null;
		}
		int rand_num = Random.Range(0, obj.Length);
		float randomY = Random.Range(0.0f, 2.0f);
		Vector3 newPos = new Vector3(transform.position.x, transform.position.y+randomY, transform.position.z);
		Instantiate(obj[rand_num], newPos, Quaternion.identity);

		yield return new WaitForSeconds(mult);
		StartCoroutine(Spawn());
	}
}





