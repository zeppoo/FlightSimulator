using UnityEngine;

public class YawSwitch : MonoBehaviour
{
    [SerializeField] private GameObject rudder;
    [SerializeField] public float yaw;

    // Update is called once per frame
    void Update()
    {
        yaw = Input.GetAxis("Yaw");
        rudder.transform.localRotation = Quaternion.Euler(-90, rudder.transform.localRotation.y, 0 + yaw * 25);
    }
}
