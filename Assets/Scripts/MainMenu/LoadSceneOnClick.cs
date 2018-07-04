using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour {

	public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
        GameObject.FindGameObjectWithTag("GameController").GetComponent<PNetworkManager>().currentScene = sceneIndex;
        SceneManager.sceneLoaded += GameObject.FindGameObjectWithTag("GameController").GetComponent<PNetworkManager>().OnSceneLoaded;
        SceneManager.sceneLoaded += GameObject.FindGameObjectWithTag("NetworkManager").GetComponent<StartScript>().OnSceneLoaded;
    }
}
