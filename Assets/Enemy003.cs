using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy003 : MonoBehaviour//p.154「両回転渦巻弾」CBiDirectionalSpiralShooter
{
    [SerializeField]
    float interval, angleRate1, angleRate2;
    [SerializeField]
    EBulColor bulColor, bulColor2;
    float time = 0, shotAngle1 = 180, shotAngle2 = 180, time2 = 0;
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
                    Bullet.CreateBullet((int)bulColor, transform.position.x, transform.position.y, shotAngle1 + 90.0f * i, 0, 0.038f, 0);
                    Bullet.CreateBullet((int)bulColor2, transform.position.x, transform.position.y, shotAngle2 + 90.0f * i, 0, 0.044f, 0);
                }
                time -= interval;
                shotAngle1 += angleRate1;
                shotAngle2 += angleRate2;
            }
        }
        else { time2 += Time.deltaTime; }
    }
}
