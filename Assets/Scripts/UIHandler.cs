using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

class UIHandler : MonoBehaviour
{
    private GameObject UI;
    private Transform Canvas;

    //UI Time handling / displaying
    float minutes;
    float seconds;
    float fraction;

    void Start()
    {
        Canvas = gameObject.transform.GetChild(0);
    }

    void Update()
    {
        //UI Time handling / displaying
        minutes = Gamecontroller.instance.GetComponent<Gamecontroller>().currentTime / 60;
        seconds = Gamecontroller.instance.GetComponent<Gamecontroller>().currentTime % 60;
        Canvas.GetChild(0).GetChild(1).GetChild(0).GetComponent<Text>().text = String.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void SetUI(string buildingTag)
    {
        for(int i = 0; i < Canvas.childCount; i++)
        {
            for (int t = 0; t < Canvas.GetChild(i).childCount; t++)
            {
                var child = Canvas.GetChild(i).GetChild(t);
                if (child.transform.tag == "Panel")
                {
                    child.gameObject.SetActive(false);
                }

                if (child.transform.name == buildingTag + "Panel")
                {
                    child.gameObject.SetActive(true);
                }
            }
        }
    }

    public void RemoveUI()
    {
        for (int i = 0; i < Canvas.childCount; i++)
        {
            var child = Canvas.GetChild(i);
            if (child.transform.tag == "Panel")
            {
                child.gameObject.SetActive(false);
            }
        }
    }
}
