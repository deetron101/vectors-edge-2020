using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeroGMovement : MonoBehaviour
{
    public float rotationSpeed = 2.5f;
    public float thrustMultiplier = 100;

    private Rigidbody rb;
    private Controls controls;

    private void Awake()
    {
        controls = new Controls();
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float zAxis = 0;
        float yAxis = 0;
        float rotateAxis = 0;

        if (name == "Player 1")
        {
            zAxis = controls.Player.Player1Move.ReadValue<float>();
            rotateAxis = controls.Player.Player1Rotate.ReadValue<float>();
        }
        else
        {
            zAxis = controls.Player.Player2Move.ReadValue<float>();
            rotateAxis = controls.Player.Player2Rotate.ReadValue<float>();
        }

        ThrustForward(zAxis*thrustMultiplier, yAxis*thrustMultiplier);
        Rotate(transform, rotateAxis*rotationSpeed);
    }

    private void ThrustForward(float zAmount, float yAmount)
    {
        Vector3 force = transform.forward * zAmount + transform.right * yAmount;
        rb.AddForce(force);
    }

    private void Rotate(Transform t, float rotateAmount)
    {
        t.Rotate(0, rotateAmount, 0);
    }
}
