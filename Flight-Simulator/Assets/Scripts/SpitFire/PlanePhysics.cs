using UnityEngine;
using UnityEngine.UIElements;

public class PlanePhysics : MonoBehaviour
{
    [Header("Plane Specifications")]
    [SerializeField] private string aircraftName;
    [SerializeField] private float weightKg;
    [SerializeField] private float wingArea;
    [SerializeField] private float horsePower;

    [Header("Plane stats")]
    [SerializeField] private int speed;
    [SerializeField] private int altitude;
    [SerializeField] private float thrust;
    [SerializeField] private float aoa;
    [SerializeField] private float lift;
    [SerializeField] private float drag;
    private Rigidbody rb;

    public float liftForce = 10f;
    public float dragFactor = 0.01f;

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

        transform.Rotate(new Vector3(pitch, yaw, -roll));
        transform.Translate(new Vector3(0, 0, 1));

        ApplyAerodynamics();
    }

    void ApplyAerodynamics()
    {
        Vector3 forwardVector = gameObject.transform.forward;
        Vector3 relativeWindDirection = Vector3.up;
        aoa = Vector3.Angle(forwardVector, relativeWindDirection);
        Debug.Log("Angle of Attack: " + aoa);
        float liftC = GetCl(aoa);
        float airDens = GetAirDens(altitude);
    }

    private float GetCl(float angleOfAttack)
    {
        float Cl = 0 + 0.11f * angleOfAttack;
        return Cl;
    }

    private float GetAirDens(float Altitude)
    {
        float AirDens = 0;
        return AirDens;
    }
}
