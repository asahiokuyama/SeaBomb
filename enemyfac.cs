using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyfac : MonoBehaviour
{
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0f, 2f);
    }

    void Spawn()
    {
        Instantiate(enemy, new Vector3(Random.Range(-10f, 10f), transform.position.y,transform.position.z), transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
