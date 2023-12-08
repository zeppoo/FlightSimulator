using UnityEngine;

public class RollSwitch : MonoBehaviour
{
    [SerializeField] private GameObject eleron_Left;
    [SerializeField] private GameObject eleron_Right;
    [SerializeField] public float roll;
    [SerializeField] private float speed;
    private Vector3 direction;

    // Update is called once per frame
    void Update()
    {
        roll = Input.GetAxis("Horizontal");

        eleron_Left.transform.localRotation = Quaternion.Euler(-90 + roll * 25, eleron_Left.transform.localRotation.y, eleron_Left.transform.localRotation.z);
        eleron_Right.transform.localRotation = Quaternion.Euler(-90 + -roll * 25, eleron_Right.transform.localRotation.y, eleron_Right.transform.localRotation.z);
    }
}
