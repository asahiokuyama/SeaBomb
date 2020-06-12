using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{

    public int time = 60;
    int count = 0;

    GameObject clock;
    GameObject fin;
    GameObject finpanel;
    GameObject score;
    // Start is called before the first frame update
    void Start()
    {
        clock = GameObject.Find("Time");
        fin = GameObject.Find("Finish");
        finpanel = GameObject.Find("Finpanel");
        score = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
            count++;
        }
        else
        {
            fin.GetComponent<Text>().text = "Finish!!" + "\n" +"Score:"+ score.GetComponent<score>().count;
            finpanel.GetComponent<Image>().fillCenter = true;
        }

        if(count >= 60)
        {
            time--;
            count = 0;
        }

        clock.GetComponent<Text>().text = "Time:" + time;
    }
}
