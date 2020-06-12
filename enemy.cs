using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    public float speed;

    GameObject score;
    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        speed = Random.Range(2f, 10f);

        transform.position += new Vector3(0, 0, -speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bom"))
        {
            Destroy(gameObject);
            score.GetComponent<score>().countup();
        }
    }
}
