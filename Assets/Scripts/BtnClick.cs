﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnClick : MonoBehaviour {
    public List<GameObject> Prefabs;
    public GameObject Player;
    GameObject ObjectToAdd;
    Ray ray;
    RaycastHit hitInfo;
    bool newInstance = false;
    private PlayerController controller;
    public GameObject SelectedGameObject;
    public GameObject AttackFlag;

	// Use this for initialization
	void Start () {
        controller = Player.GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
        if (newInstance == false)
        {
            return;
        }
        CastRay();
        ObjectToAdd.transform.position = hitInfo.point;
        if (Input.GetMouseButton(0))
        {
            controller.CreateBuilding(ObjectToAdd.tag);
            newInstance = false;
        }
	}

    public void BarracksBtnClicked()
    {
        CreateGameObject("Barracks");
    }

    public void MineBtnClicked()
    {
        CreateGameObject("Mine");
    }

    public void SawmillBtnClicked()
    {
        CreateGameObject("Sawmill");
    }

    public void Mill_BackeryBtnClicked()
    {
        CreateGameObject("Mill_Backery");
    }

    public void WorkerBtnClicked()
    {
        CreateUnit("Worker");
    }

    public void WardogBtnClicked()
    {
        CreateUnit("Wardog");
    }

    public void WarriorBtnClicked()
    {
        CreateUnit("Warrior");
    }

    public void GolemBtnClicked()
    {
        CreateUnit("Golem");
    }


    private void CreateGameObject(string prefAb)
    {
        CastRay();
        var toAdd = Prefabs.Find(x => x.name == prefAb);
        ObjectToAdd = Instantiate(toAdd, hitInfo.point, Quaternion.Euler(-90, 0, 0));
        newInstance = true;
    }

    private void CreateUnit(string prefAb)
    {
        var toAdd = Prefabs.Find(x => x.name == prefAb);
        Instantiate(toAdd, SelectedGameObject.transform.position, Quaternion.Euler(0,0,0));
    }

    void CastRay()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Terrain.activeTerrain.GetComponent<Collider>().Raycast(ray, out hitInfo, 1000);
    }
}
