using UnityEngine;

public class PitchSwitch : MonoBehaviour
{
    [SerializeField] private GameObject ruli;
    [SerializeField] public float pitch;

    // Update is called oncSe per frame
    void Update()
    {
        pitch = Input.GetAxis("Vertical");

        ruli.transform.localRotation = Quaternion.Euler(-90 + pitch * 25, ruli.transform.localRotation.y, ruli.transform.localRotation.z);


    }
}
