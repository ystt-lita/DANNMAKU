using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy005 : MonoBehaviour
{
    Enemy004 e004;
    const float MaxAngleRate = 13.1f, MaxBAngleRate = 0.15f;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        e004 = GetComponent<Enemy004>();
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 10)
        {
            time -= 10;
        }
        if (time < 4)
        {
            e004.angleRate = MaxAngleRate;
            e004.bAngleRate = MaxBAngleRate;
        }
        else if (4 <= time && time < 5)
        {
            e004.angleRate = MaxAngleRate * (4.5f - time) * 2;
            e004.bAngleRate = MaxBAngleRate * (4.5f - time) * 2;
        }
        else if (5 <= time && time < 9)
        {
            e004.angleRate = -MaxAngleRate;
            e004.bAngleRate = -MaxBAngleRate;
        }
        else
        {
            e004.angleRate = MaxAngleRate * (time - 9.5f) * 2;
            e004.bAngleRate = MaxBAngleRate * (time - 9.5f) * 2;
        }
    }
}
