using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
	public static GameManager instance;

	public delegate void StateChanged();
	public static event StateChanged OnStateChanged;

	public enum States{
		RUN,
		PAUSE,
	};
	States m_state;
	public States state{
		get { return m_state; }
		set {
			m_state = value;
			if(OnStateChanged!=null){
				OnStateChanged();
			}
		}
	}

	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	void Awake()
	{
		instance = this;
		state = States.RUN;
	}
}
