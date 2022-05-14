using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRoll : MonoBehaviour
{
    public float rollx = 0;
    public float rolly = 0;
    public float rollz = 0;
    //Transform Sun = GameObject.Find("Directional Light").transform;
    public float suntime = 0;

    private void Update()
    {
        Transform Sun = this.transform;
        Vector3 localAngle = Sun.localEulerAngles;
        localAngle.x = rollx;
        localAngle.y = rolly;
        localAngle.z = rollz;

        Sun.localEulerAngles = localAngle;
    }

    public void AngleOfSunlight(float SunAngle)
    {
        if (SunAngle >= 0)
        {
            rollx = SunAngle * -11.66f;
            rollx += 69.96f;
        }
        else
        {
            rollx = SunAngle * 11.66f;
            rollx += 69.96f;
        }
        rolly = SunAngle * 15.0f;
        rollz = SunAngle * 11.66f;
        //Debug.Log("x =" + rollx + " /y ="+ rolly + " /z =" + rollz);

        suntime = SunAngle;
    }

    public void AngleOfSunlightSimple(float SunAngle)
    {
        rollx = SunAngle * 7.5f;
        //Debug.Log(rollx);
        

    }

    public void Test(float SunAngle)
    {
        //Debug.Log(SunAngle);
    }
}
