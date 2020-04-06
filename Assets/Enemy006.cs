using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy006 : MonoBehaviour
{
    GameObject option;
    GameObject[] options = new GameObject[5];
    // Start is called before the first frame update
    void Start()
    {
        option = Resources.Load<GameObject>("Option");
        for (int i = 0; i < 5; i++)
        {
            options[i] = Instantiate(option, transform);
            options[i].transform.localPosition = new Vector3(0, -2, 0);
            options[i].transform.RotateAround(transform.position, Vector3.forward, 72 * i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var item in options)
        {
            item.transform.RotateAround(transform.position, Vector3.forward, 137 * Time.deltaTime);
        }
    }
}
