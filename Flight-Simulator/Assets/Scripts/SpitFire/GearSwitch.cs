using UnityEngine;

public class GearSwitch : MonoBehaviour
{
    [SerializeField] private Animator Gears;
    [SerializeField] private bool gearState = true;
    [SerializeField] private float timer;
    private bool switchWait = true;
    private float counter = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.G) && switchWait == true)
        {
            switchWait = false;
            gearState = !gearState;
            if (gearState == true)
            {
                Gears.SetTrigger("GearDown");
            }
            else if (gearState == false)
            {
                Gears.SetTrigger("GearUp");
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
