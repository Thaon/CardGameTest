using UnityEngine;
using System.Collections.Generic;

public class GameEvent : MonoBehaviour
{

	#region Member variables
	
	string m_text;
	List<string> m_affectedStats;
	
	#endregion
	
	
	#region Getters and Setters
	
	public string GetEventText() {return m_text;}
	public List<string> GetAffectedStats() {return m_affectedStats;}
	
	public void SetAffectedStats(List<string> stats) {m_affectedStats = stats;}
	
	#endregion


	public GameEvent(string text) {m_text = text;}

}
