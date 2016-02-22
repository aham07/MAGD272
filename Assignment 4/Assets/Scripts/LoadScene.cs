using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadScene : MonoBehaviour {

    public string firstSceneName;   

    public void loadFirstScene(){
        SceneManager.LoadScene(firstSceneName, LoadSceneMode.Single);

    }
}
