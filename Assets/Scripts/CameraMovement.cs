using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target1, target2;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    public float cameraYMin = 14;
    public float cameraYMax = 50;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 midPoint = (target1.position + target2.position) / 2;
        Vector3 desiredPosition = midPoint + offset;
        Vector3 heading = target1.position - target2.position;
        float distance = heading.magnitude;
        desiredPosition.y = Mathf.Clamp(distance, cameraYMin, cameraYMax);

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

    }
}
