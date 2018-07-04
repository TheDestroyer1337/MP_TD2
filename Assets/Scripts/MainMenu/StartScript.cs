using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour {

    public GameObject GameControllerGO;

	void Start () {
        GameControllerGO.SetActive(true);
	}

    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        GameControllerGO.SetActive(true);
    }
}
