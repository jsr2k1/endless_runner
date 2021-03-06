﻿using UnityEngine;
using System.Collections;

public class OffsetScroller : MonoBehaviour
{
	public float scrollSpeed;
	Vector2 savedOffset;
	float mult = 0.1f;

	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	
	void Start()
	{
		savedOffset = renderer.sharedMaterial.GetTextureOffset("_MainTex");
	}

	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	
	void Update()
	{
		if(GameManager.instance.state != GameManager.States.RUN){
			return;
		}
		float x = Mathf.Repeat(Time.time * scrollSpeed * mult, 1);
		Vector2 offset = new Vector2(x, savedOffset.y);
		renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
	}

	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	
	void OnDisable()
	{
		renderer.sharedMaterial.SetTextureOffset("_MainTex", savedOffset);
	}
}
