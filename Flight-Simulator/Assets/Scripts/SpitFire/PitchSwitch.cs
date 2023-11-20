using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitchSwitch : MonoBehaviour
{
    [SerializeField] private GameObject ruli;
    [SerializeField] private float pitch;

    // Update is called once per frame
    void Update()
    {
        pitch = Input.GetAxis("Vertical");

        ruli.transform.eulerAngles = new Vector3(ruli.transform.eulerAngles.x + pitch * 25, ruli.transform.eulerAngles.y, ruli.transform.eulerAngles.z);

    }
}
