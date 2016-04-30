using UnityEngine;

public class Objective : MonoBehaviour
{

	#region Member variables
	
	string m_text;
	
	#endregion
	
	
	#region Getters and Setters
	
	public string GetObjectiveText() {return m_text;}
	
	#endregion
	
	public Objective(string text) {m_text = text;}
	
}
