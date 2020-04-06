using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy002 : MonoBehaviour//p.145「多方向渦巻弾」CMultipleSpiralShooter
{
    [SerializeField]
    float interval, angleRate;
    [SerializeField]
    EBulColor bulColor;
    float time = 0, shotAngle = 180, time2 = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (time2 > 1)
        {
            time += Time.deltaTime;
            if (time >= interval)
            {
                for (int i = 0; i < 4; i++)
                {
                    Bullet.CreateBullet((int)bulColor, transform.position.x, transform.position.y, shotAngle + 90.0f * i, 0, 0.04f, 0);
                }
                time -= interval;
                shotAngle += angleRate;
            }
        }
        else { time2 += Time.deltaTime; }
    }
}
