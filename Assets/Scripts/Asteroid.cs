using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour
{
    private Rigidbody other_rb;

    public int forceMultiplier = 5000;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.GetComponent<Rigidbody>())
        {
            other_rb = collision.gameObject.GetComponent<Rigidbody>();
            other_rb.AddRelativeForce(-other_rb.position * forceMultiplier);
        }
    }
}
