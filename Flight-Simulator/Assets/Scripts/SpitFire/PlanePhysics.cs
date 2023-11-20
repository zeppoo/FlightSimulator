using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlanePhysics : MonoBehaviour
{

    [SerializeField] private float Weight;
    [SerializeField] private float thrust;
    [SerializeField] private float lift;
    [SerializeField] private float drag;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        float pitch = GetComponent<PitchSwitch>().pitch;
        float roll = GetComponent<RollSwitch>().roll;
        float yaw = GetComponent<YawSwitch>().yaw;

        gameObject.transform.Rotate(new Vector3(pitch, yaw, roll));
        rb.AddForce(Vector3.forward * 50);
    }

    
}
