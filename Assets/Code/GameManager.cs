using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{

	#region Member variables
	
	List<Card> m_hand;
	int m_points;
	int m_winningPlayer;
	Objective m_objective;
	GameEvent m_currentEvent;
	
	#endregion

	
	#region Getters and Setters
	
	public int GetTotalStrength()
	{
		int tStr = 0;
		foreach (Card card in m_hand)
		{
			tStr += card.GetStrength();
		}
		return tStr;
	}
	public int GetTotalSpeed()
	{
		int tSpd = 0;
		foreach (Card card in m_hand)
		{
			tSpd += card.GetSpeed();
		}
		return tSpd;
	}
	public int GetTotalDefense()
	{
		int tDef = 0;
		foreach (Card card in m_hand)
		{
			tDef += card.GetDefense();
		}
		return tDef;
	}
	public int GetTotalIntelligence()
	{
		int tInt = 0;
		foreach (Card card in m_hand)
		{
			tInt += card.GetIntelligence();
		}
		return tInt;
	}
	public List<Card> GetHand() {return m_hand;}
	public int GetPoints() {return m_points;}
	public int GetWinningPlayer() {return m_winningPlayer;}
	public Objective GetPersonalObjective() {return m_objective;}
	public GameEvent GetCurrentEvent() {return m_currentEvent;}

	#endregion


	void Start ()
	{
		m_hand = new List<Card>();
	}
	
}
