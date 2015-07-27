using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class MapButton : MonoBehaviour, IPointerClickHandler
{
	public void OnPointerClick(PointerEventData data)
	{
		string num_level = name.Split('_')[1];
		Application.LoadLevel("Level_" + num_level);
	}
}
