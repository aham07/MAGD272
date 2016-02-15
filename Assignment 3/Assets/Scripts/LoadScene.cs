using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadScene : MonoBehaviour {

    public string firstSceneName;
    public string secondSceneName;
    public string thirdSceneName;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void loadFirstScene(){
        SceneManager.LoadScene(firstSceneName, LoadSceneMode.Single);

    }

    public void loadSecondScene()
    {
        SceneManager.LoadScene(secondSceneName, LoadSceneMode.Single);

    }

    public void loadThirdScene()
    {
        SceneManager.LoadScene(thirdSceneName, LoadSceneMode.Single);

    }
}
