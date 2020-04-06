using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy001 : MonoBehaviour//p.138「渦巻弾ver.1」CSpiralShooter
{
    [SerializeField]
    float interval, angleRate;
    [SerializeField]
    EBulColor bulColor;
    float time = 0, shotAngle = 180;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= interval)
        {
            Bullet.CreateBullet((int)bulColor, transform.position.x, transform.position.y, shotAngle, 0, 0.06f, 0);
            time -= interval;
            shotAngle += angleRate;
        }
    }
}
