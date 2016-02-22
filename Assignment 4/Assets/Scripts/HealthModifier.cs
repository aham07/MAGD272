using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthModifier : MonoBehaviour {

   	public Text Strength;
	public Text Defense;
	public Text Charisma;
	public Text Willpower;
	public Text Cunning;
	public Text Constitution;
	public Text pointsText;

	public void Plus1 () {
			if (StatsManager.points != 0) {				
				StatsManager.strength++;
				StatsManager.points--;
				Strength.text = "Strength: " + StatsManager.strength.ToString ();
				pointsText.text = "Points Avalible: " + StatsManager.points.ToString ();
			}
	}

	public void Minus1 () {
		if (StatsManager.strength > 10) {				
			StatsManager.strength--;
			StatsManager.points++;
			Strength.text = "Strength: " + StatsManager.strength.ToString ();
			pointsText.text = "Points Avalible: " + StatsManager.points.ToString ();
		}
	}

	public void Plus2 () {
		if (StatsManager.points != 0) {				
			StatsManager.defense++;
			StatsManager.points--;
			Defense.text = "Defense: " + StatsManager.defense.ToString ();
			pointsText.text = "Points Avalible: " + StatsManager.points.ToString ();
		}
	}

	public void Minus2 () {
		if (StatsManager.defense > 10) {				
			StatsManager.defense--;
			StatsManager.points++;
			Defense.text = "Defense: " + StatsManager.defense.ToString ();
			pointsText.text = "Points Avalible: " + StatsManager.points.ToString ();
		}
	}

	public void Plus3 () {
		if (StatsManager.points != 0) {				
			StatsManager.charisma++;
			StatsManager.points--;
			Charisma.text = "Charisma: " + StatsManager.charisma.ToString ();
			pointsText.text = "Points Avalible: " + StatsManager.points.ToString ();
		}
	}

	public void Minus3 () {
		if (StatsManager.charisma > 10) {				
			StatsManager.charisma--;
			StatsManager.points++;
			Charisma.text = "Charisma: " + StatsManager.charisma.ToString ();
			pointsText.text = "Points Avalible: " + StatsManager.points.ToString ();
		}
	}

	public void Plus4 () {
		if (StatsManager.points != 0) {				
			StatsManager.willpower++;
			StatsManager.points--;
			Willpower.text = "Willpower: " + StatsManager.willpower.ToString ();
			pointsText.text = "Points Avalible: " + StatsManager.points.ToString ();
		}
	}

	public void Minus4 () {
		if (StatsManager.willpower > 10) {				
			StatsManager.willpower--;
			StatsManager.points++;
			Willpower.text = "Willpower: " + StatsManager.willpower.ToString ();
			pointsText.text = "Points Avalible: " + StatsManager.points.ToString ();
		}
	}

	public void Plus5 () {
		if (StatsManager.points != 0) {				
			StatsManager.cunning++;
			StatsManager.points--;
			Cunning.text = "Cunning: " + StatsManager.cunning.ToString ();
			pointsText.text = "Points Avalible: " + StatsManager.points.ToString ();
		}
	}

	public void Minus5 () {
		if (StatsManager.cunning > 10) {				
			StatsManager.cunning--;
			StatsManager.points++;
			Cunning.text = "Cunning: " + StatsManager.cunning.ToString ();
			pointsText.text = "Points Avalible: " + StatsManager.points.ToString ();
		}
	}

	public void Plus6 () {
		if (StatsManager.points != 0) {				
			StatsManager.constitution++;
			StatsManager.points--;
			Constitution.text = "Constitution: " + StatsManager.constitution.ToString ();
			pointsText.text = "Points Avalible: " + StatsManager.points.ToString ();
		}
	}

	public void Minus6 () {
		if (StatsManager.constitution > 10) {				
			StatsManager.constitution--;
			StatsManager.points++;
			Constitution.text = "Constitution: " + StatsManager.constitution.ToString ();
			pointsText.text = "Points Avalible: " + StatsManager.points.ToString ();
		}
	}
}
