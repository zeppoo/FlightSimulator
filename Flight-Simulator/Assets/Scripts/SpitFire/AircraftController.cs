using UnityEngine;

public class AircraftController : MonoBehaviour
{
    public float speed = 20f;
    public float rotationSpeed = 3f;
    public float liftForce = 10f;
    public float dragFactor = 0.01f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed * Time.deltaTime;
        transform.Translate(movement);

        float rotation = horizontalInput * rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up, rotation);

        ApplyAerodynamics();
    }

    void ApplyAerodynamics()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        // Calculate lift force based on the angle of attack
        float angleOfAttack = Vector3.SignedAngle(Vector3.forward, rb.velocity.normalized, Vector3.up);
        float lift = Mathf.Clamp(angleOfAttack, -15f, 15f) * liftForce;

        // Apply lift force
        Vector3 liftForceVector = transform.up * lift;
        rb.AddForce(liftForceVector);

        // Apply drag force
        Vector3 dragForce = -rb.velocity.normalized * rb.velocity.sqrMagnitude * dragFactor;
        rb.AddForce(dragForce);
    }
}
