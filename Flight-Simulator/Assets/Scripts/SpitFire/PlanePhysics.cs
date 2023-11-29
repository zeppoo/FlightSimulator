using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlanePhysics : MonoBehaviour
{
    [SerializeField] private float turnTime;
    [SerializeField] private float rollTime;
    [SerializeField] private float yawTime;
    [SerializeField] private float Weight;
    [SerializeField] private float thrust;
    public float liftForce = 10f;
    [SerializeField] private float dragFactor = 0.01f;
    [SerializeField] private float drag;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        float pitch = GetComponent<PitchSwitch>().pitch;
        float roll = GetComponent<RollSwitch>().roll;
        float yaw = GetComponent<YawSwitch>().yaw;

        gameObject.transform.Rotate(new Vector3(pitch * turnTime, yaw * yawTime, -roll * rollTime));
        //transform.Translate(Vector3.forward * 60 * Time.deltaTime);



        ApplyAerodynamics();
    }

    void ApplyAerodynamics()
    {
        // Calculate lift force based on the angle of attack
        float angleOfAttack = Vector3.SignedAngle(Vector3.forward, rb.velocity.normalized, Vector3.up);
        float lift = Mathf.Clamp(angleOfAttack, -15f, 15f) * liftForce;

        // Apply lift force
        Vector3 LiftForce = transform.up * lift;
        rb.AddForce(LiftForce);

        // Apply drag force
        Vector3 dragForce = -rb.velocity.normalized * rb.velocity.sqrMagnitude * dragFactor;
        rb.AddForce(dragForce);
    }
}
