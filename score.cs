using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public int count = 0;

    GameObject point;
    GameObject time;
    // Start is called before the first frame update
    void Start()
    {
        point = GameObject.Find("Score");
        time = GameObject.Find("Time");
    }

    // Update is called once per frame
    void Update()
    {
        point.GetComponent<Text>().text = "Score:" + count;
    }
    
    public void countup()
    {
        if (time.GetComponent<timer>().time > 0)
        {
            count++;
        }
    }

}
