using UnityEngine;
using System.Collections;

public enum CardType {Brain, Chassie, Weapon}

public class Card : MonoBehaviour
{

	#region Member variables
	
	Sprite m_icon;
	CardType m_type;
	string m_flavourText;
	int m_str, m_def, m_spd, m_int;
	
	#endregion


	#region Getters and Setters
	
	public int GetStrength() {return m_str;}
	public int GetDefense() {return m_def;}
	public int GetSpeed() {return m_spd;}
	public int GetIntelligence() {return m_int;}
	public string GetFlavourText() {return m_flavourText;}
	public CardType GetCardType() {return m_type;}
	public Sprite GetIcon() {return m_icon;}
	
	#endregion
	
	
	public Card(Sprite icon, CardType type, int str, int def, int spd, int inte)
	{
		m_icon = icon;
		m_type = type;
		m_str = str;
		m_def = def;
		m_spd = spd;
		m_int = inte;
	}
	
}
