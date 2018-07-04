using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamecontroller : MonoBehaviour
{
    //Singleton
    public static Gamecontroller instance = null;
    //Everything else
    private float startTime;
    public float currentTime { get; set; }
    public List<float> WaveStartTimes;

    private void Awake()
    {
        //Singelton
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);

        //Everything else
        startTime = Time.time;
    }

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Timemanager
        currentTime = Time.time - startTime;

        //Wave handling
        //Todo Redo with Invoke() or StartCorountine()
        for (int i = 0; i < WaveStartTimes.Count; i++)
        {
            if (currentTime >= WaveStartTimes[i])
            {
                Debug.Log("yes");
                WaveStartTimes.RemoveAt(i);
                i--;
                gameObject.GetComponent<UnitAI>().StartWave();
            }
        }
    }
}