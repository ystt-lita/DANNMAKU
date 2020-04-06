using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    float slant;
    [SerializeField]
    float slow;
    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        dir = new Vector3(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        dir.x = 0; dir.y = 0;
        if (Input.GetKey(KeyCode.UpArrow)) { dir.y += 1; }
        if (Input.GetKey(KeyCode.RightArrow)) { dir.x += 1; }
        if (Input.GetKey(KeyCode.DownArrow)) { dir.y -= 1; }
        if (Input.GetKey(KeyCode.LeftArrow)) { dir.x -= 1; }
        if (dir.magnitude > 1)
        {
            dir.Normalize();
            dir *= slant;
        }
        if (Input.GetKey(KeyCode.LeftShift)) { dir *= slow; }
        if (dir.magnitude > 0)
        {
            transform.position += dir * speed;
        }
    }
}
