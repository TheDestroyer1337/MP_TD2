using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour {

	public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
        GameObject.FindGameObjectWithTag("GameController").GetComponent<PNetworkManager>().currentScene = sceneIndex;
    }
}
