using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour {

    public GameObject GameControllerGO;

	void Start () {
        GameControllerGO.SetActive(true);
	}
}
