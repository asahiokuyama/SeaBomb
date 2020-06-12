using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


//attached to button
public class retry : MonoBehaviour
{
    public GameObject botan;
    GameObject time;
    // Start is called before the first frame update
    void Start()
    {
        time = GameObject.Find("Time");
    }

    // Update is called once per frame
    void Update()
    {
        if (time.GetComponent<timer>().time > 0)
        {
            
        }
        else
        {
            botan.GetComponent<RectTransform>().position = new Vector3(366, 200, 0);
        }
    }

    public void retrygame()
    {
        SceneManager.LoadScene("title");
    }
}
