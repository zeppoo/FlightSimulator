using UnityEngine;

public class PlanePhysics : MonoBehaviour
{
    [Header("Plane Specifications")]
    [SerializeField] private string aircraftName;
    [SerializeField] private float weight;
    [SerializeField] private float wingArea;
    [SerializeField] private float horsePower;

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

        transform.Rotate(new Vector3(pitch, yaw, -roll));
        transform.Translate(new Vector3(0, 0, 1));
    }


}
