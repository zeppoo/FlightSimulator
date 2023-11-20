using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YawSwitch : MonoBehaviour
{
    [SerializeField] private GameObject rudder;
    [SerializeField] private float yaw;

    // Update is called once per frame
    void Update()
    {
        yaw = Input.GetKey(KeyCode.Q) ? 1 : Input.GetKey(KeyCode.E) ? -1 : 0;

        rudder.transform.rotation = Quaternion.Euler(-90, transform.rotation.y, 0 + yaw * 25);

        
    }
}
