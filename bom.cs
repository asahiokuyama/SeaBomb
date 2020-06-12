using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
public class bom : MonoBehaviour
{
    public GameObject particle;
    public GameObject particle2;
    // Start is called before the first frame update
    void Start()
    {
        //particle = this.GetComponent<ParticleSystem>();

        // ここで Particle System を停止する.
        

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            Destroy(gameObject);
            Instantiate(particle, transform.position, transform.rotation);
        }

        if (collision.gameObject.CompareTag("water"))
        {
            Debug.Log("e");
            Destroy(gameObject);
            Instantiate(particle2, transform.position, transform.rotation);
        }
    }
}
