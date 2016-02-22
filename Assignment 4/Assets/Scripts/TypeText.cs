using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TypeText : MonoBehaviour {

    public string myText = "Enter your character name:";
    public float interLetterTime;
    public Text targetTypeText;
	public InputField userInput;

	void Start(){
		StartCoroutine (addText (myText));
	}

    IEnumerator addText(string text) {
        int textLength = text.Length;
        for(int i=0; i<textLength + 1; i++){
            targetTypeText.text = text.Substring(0, i);
            yield return new WaitForSeconds(interLetterTime);
        }
    }

	public void StoreUserName(){
		StatsManager.username = userInput.text;
		StartCoroutine(addText("Welcome, " + StatsManager.username + ", press 'Escape' to upgrade stats."));
	}
}
