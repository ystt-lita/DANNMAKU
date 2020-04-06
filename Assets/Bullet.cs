using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Camera mainCam;
    static Dictionary<int, GameObject> bullet;
    float angleRate, speed, speedRate;
    Rect aliveArea;
    static string[] bulPrefabName = {
        "b001r", "b001b", "b001g", "b001o", "b001p", "b001v",
        "b002r", "b002b", "b002g", "b002o", "b002p", "b002v",
        "b003r", "b003b", "b003g", "b003o", "b003p", "b003v",
        "b004r", "b004b", "b004g", "b004o", "b004p", "b004v",
        "b005r", "b005b", "b005g", "b005o", "b005p", "b005v",
        "b006r", "b006b", "b006g", "b006o", "b006p", "b006v",
        "b007r", "b007b", "b007g", "b007o", "b007p", "b007v",
        "b008r", "b008b", "b008g", "b008o", "b008p", "b008v",
        "b009r", "b009b", "b009g", "b009o", "b009p", "b009v",
        "b010r", "b010b", "b010g", "b010o", "b010p", "b010v",
        "b011r", "b011b", "b011g", "b011o", "b011p", "b011v",
        "b012r", "b012b", "b012g", "b012o", "b012p", "b012v",
        "b013r", "b013b", "b013g", "b013o", "b013p", "b013v",
        "b014r", "b014b", "b014g", "b014o", "b014p", "b014v" };
    // Start is called before the first frame update
    void Start()
    {
        aliveArea = new Rect(-0.1f, -0.1f, 1.2f, 1.2f);
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * speed;
        transform.Rotate(Vector3.forward, angleRate);
        speed += speedRate;
        if (!aliveArea.Contains(mainCam.WorldToViewportPoint(transform.position)))
        {
            Destroy(gameObject);
        }
    }
    static public GameObject CreateBullet(int kind, float x, float y, float angle, float angleRate, float speed, float speedRate)
    {
        if (bullet == null)
        {
            bullet = new Dictionary<int, GameObject>();
        }
        if (!bullet.ContainsKey(kind) || bullet[kind] == null)
        {
            bullet[kind] = Resources.Load<GameObject>(bulPrefabName[kind]);
        }
        GameObject bul = Instantiate(bullet[kind]);
        bul.transform.position = new Vector3(x, y, 0);
        bul.transform.rotation = Quaternion.Euler(0, 0, angle);
        Bullet b = bul.GetComponent<Bullet>();
        b.angleRate = angleRate;
        b.speed = speed;
        b.speedRate = speedRate;

        return bul;
    }
}

public enum EBulColor
{
    EllipseRed,
    EllipseBlue,
    EllipseGreen,
    EllipsePink,
    EllipseOrange,
    EllipseViolet,
    ClossSphereRed,
    ClossSphereBlue,
    ClossSphereGreen,
    ClossSpherePink,
    ClossSphereOrange,
    ClossSphereViolet,
    DiamondRed,
    DiamondBlue,
    DiamondGreen,
    DiamondPink,
    DiamondOrange,
    DiamondViolet,
    DoubleRed,
    DoubleBlue,
    DoubleGreen,
    DoublePink,
    DoubleOrange,
    DoubleViolet,
    SphereRed,
    SphereBlue,
    SphereGreen,
    SpherePink,
    SphereOrange,
    SphereViolet,
    CrossRed,
    CrossBlue,
    CrossGreen,
    CrossPink,
    CrossOrange,
    CrossViolet,
    FlameRed,
    FlameBlue,
    FlameGreen,
    FlamePink,
    FlameOrange,
    FlameViolet,
    ArrowRed,
    ArrowBlue,
    ArrowGreen,
    ArrowPink,
    ArrowOrange,
    ArrowViolet,
    LineRed,
    LineBlue,
    LineGreen,
    LinePink,
    LineOrange,
    LineViolet,
    BigEllipseRed,
    BigEllipseBlue,
    BigEllipseGreen,
    BigEllipsePink,
    BigEllipseOrange,
    BigEllipseViolet,

    BigDiamondRed,
    BigDiamondBlue,
    BigDiamondGreen,
    BigDiamondPink,
    BigDiamondOrange,
    BigDiamondViolet,

    BigSphereRed,
    BigSphereBlue,
    BigSphereGreen,
    BigSpherePink,
    BigSphereOrange,
    BigSphereViolet,

    HugeSphereRed,
    HugeSphereBlue,
    HugeSphereGreen,
    HugeSpherePink,
    HugeSphereOrange,
    HugeSphereViolet,
    BoldLineRed,
    BoldLineBlue,
    BoldLineGreen,
    BoldLinePink,
    BoldLineOrange,
    BoldLineViolet,
};