using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollSwitch : MonoBehaviour
{
    [SerializeField] private GameObject eleron_Left;
    [SerializeField] private GameObject eleron_Right;
    [SerializeField] private float roll;
    [SerializeField] private float speed;
    private Vector3 direction;

    // Update is called once per frame
    void Update()
    {
        roll = Input.GetAxis("Horizontal");

        eleron_Left.transform.rotation = Quaternion.Euler(-90 + roll * 25, Quaternion.identity.y, Quaternion.identity.z);
        eleron_Right.transform.rotation = Quaternion.Euler(-90 + -roll * 25, Quaternion.identity.y, Quaternion.identity.z);
    }
}