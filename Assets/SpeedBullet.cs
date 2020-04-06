using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBullet : MonoBehaviour
{
    Bullet parentBullet;
    float finalSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    static public GameObject CreateSpeedBullet(int kind, float x, float y, float angle, float angleRate, float speed, float speedRate, float finalSpeed)
    {
        GameObject bul = Bullet.CreateBullet(kind, x, y, angle, angleRate, speed, speedRate);
        SpeedBullet b = bul.AddComponent<SpeedBullet>();
        b.parentBullet = bul.GetComponent<Bullet>();
        return bul;
    }
}
