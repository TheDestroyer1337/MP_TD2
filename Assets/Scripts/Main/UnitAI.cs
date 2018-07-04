using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UnitAI : MonoBehaviour
{
    //Units chilling by AttackFlag
    List<GameObject> UnitsAttackerI;
    //Units Attacking
    List<GameObject> UnitsAttackerA;
    GameObject AttackFlag;
    public float unitSpeed;


    private bool WaveOngoing = false;

    // Use this for initialization
    void Start()
    {
        AttackFlag = GameObject.FindGameObjectWithTag("AttackFlag");
        UnitsAttackerI = new List<GameObject>();
    }

    //Update is called 60 Times per Second. Is not Frame dependend.
    void FixedUpdate()
    {
        //Unit movement to the AttackFlag
        foreach (GameObject element in UnitsAttackerI)
        {
            if (element.GetComponent<CollisionHandler>().IsCollidingAF == false)
            {
                element.transform.LookAt(AttackFlag.transform);
                element.transform.Translate(0, (Terrain.activeTerrain.SampleHeight(element.transform.position) - element.transform.position.y), unitSpeed);
            }
        }

        //Units movement in Ongoing Wave
        if (WaveOngoing)
        {
            foreach ( GameObject element in UnitsAttackerA)
            {
                
            }
        }
    }

    public void AddUnit(GameObject Unit)
    {
        UnitsAttackerI.Add(Unit);
    }

    public void StartWave()
    {
        UnitsAttackerA = UnitsAttackerI.Where(x => x.GetComponent<CollisionHandler>().IsCollidingAF).ToList();
        UnitsAttackerI.RemoveAll(x => x.GetComponent<CollisionHandler>().IsCollidingAF);
        WaveOngoing = true;
    }
}