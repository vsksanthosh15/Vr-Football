using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private AudioSource AudioSource;
    private Rigidbody Rigidbody;
    public float BallSpeed;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
        Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("MainCamera"))
        {
            AudioSource.Play();
            //Rigidbody.velocity = new Vector3(0, collision.gameObject.GetComponent<Rigidbody>().angularVelocity.y, collision.gameObject.GetComponent<Rigidbody>().angularVelocity.z * BallSpeed);
        }
    }
}
