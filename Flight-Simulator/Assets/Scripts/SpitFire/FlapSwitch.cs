using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlapSwitch : MonoBehaviour
{
    [SerializeField] private Animator Gears;
    [SerializeField] private bool flapState = true;
    [SerializeField] private float timer;
    private bool switchWait = true;
    private float counter = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F) && switchWait == true)
        {
            switchWait = false;
            flapState = !flapState;
            if (flapState == true)
            {
                Gears.SetTrigger("FlapsUp");
            }
            else if (flapState == false)
            {
                Gears.SetTrigger("FlapsDown");
            }
        }

        if (switchWait == false)
        {
            if (counter >= timer)
            {
                switchWait = true;
                counter = 0;
            }
            else
            {
                counter += Time.deltaTime;
            }
        }
    }
}
