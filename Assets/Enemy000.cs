using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy000 : MonoBehaviour//p.134「方向弾ver.1」CDirectionalShooter
{
    [SerializeField]
    float interval;
    [SerializeField]
    EBulColor bulColor;
    Bullet bullet;
    float time = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= interval)//一定間隔で撃つ
        {
            Bullet.CreateBullet((int)bulColor, transform.position.x, transform.position.y, 180, 0, 0.04f, 0);
            time -= interval;
        }
    }
}
