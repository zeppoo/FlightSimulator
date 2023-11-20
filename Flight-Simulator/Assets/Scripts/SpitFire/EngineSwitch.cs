using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineSwitch : MonoBehaviour
{
    [SerializeField] private bool engineState = false;
    [SerializeField] private float rotationSpeed = 0;
    [SerializeField] private float targetSpeed;
    [SerializeField] private float speedDiff;
    [SerializeField] private float accelRate;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.T))
        {
            engineState = !engineState;
            targetSpeed = engineState == true ? 1000f : 0f;
        }

        if (engineState == true)
        {
            speedDiff = targetSpeed - rotationSpeed;
            accelRate =+ speedDiff * 0.1f;
            rotationSpeed = rotationSpeed + accelRate;
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }
}
