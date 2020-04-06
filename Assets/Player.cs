using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector3 dir;
    [SerializeField]
    float speed;
    [SerializeField]
    float slat;
    [SerializeField]
    float slow;
    // Start is called before the first frame update
    void Awake()
    {
        Application.targetFrameRate = 60;
    }
    void Start()
    {
        dir = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        dir.x = 0;
        dir.y = 0;
        if (Input.GetKey(KeyCode.UpArrow)) dir.y += 1;
        if (Input.GetKey(KeyCode.DownArrow)) dir.y -= 1;
        if (Input.GetKey(KeyCode.RightArrow)) dir.x += 1;
        if (Input.GetKey(KeyCode.LeftArrow)) dir.x -= 1;
        if (dir.magnitude > 1)
        {
            dir = dir.normalized * slat;
        }
        if (Input.GetKey(KeyCode.LeftShift)) dir *= slow;
        if (dir.magnitude > 0)
        {
            transform.position += dir * speed;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(other.gameObject);
        }
    }
}
