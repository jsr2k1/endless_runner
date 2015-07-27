using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SpriteParallax : MonoBehaviour
{
	public Transform[] sprites;
	Transform firstSprite;
	Transform middleSprite;
	Transform lastSprite;
	public int speed;

	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	void Start()
	{
		firstSprite = sprites[0];
		middleSprite = sprites[1];
		lastSprite = sprites[2];
	}

	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	void Update()
	{
		for(int i=0;i<3;i++){
			Vector3 oldPos = sprites[i].position;
			sprites[i].position = new Vector3(oldPos.x-speed, oldPos.y, oldPos.z);
		}
		if(firstSprite.position.x < -Screen.width){
			firstSprite.position = lastSprite.position + new Vector3(Screen.width, 0, 0);
			Transform tmp = firstSprite;
			firstSprite = middleSprite;
			middleSprite = lastSprite;
			lastSprite = tmp;
		}
	}
}
