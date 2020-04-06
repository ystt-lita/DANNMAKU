using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSizer : MonoBehaviour
{
    BoxCollider2D[] wall = new BoxCollider2D[4];
    // Start is called before the first frame update
    void Start()
    {
        wall = GetComponents<BoxCollider2D>();
        Vector2 viewSize = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        wall[0].size = new Vector2(1, viewSize.y * 2);
        wall[1].size = new Vector2(viewSize.x * 2, 1);
        wall[2].size = new Vector2(1, viewSize.y * 2);
        wall[3].size = new Vector2(viewSize.x * 2, 1);
        wall[0].offset = new Vector2(viewSize.x, 0);
        wall[1].offset = new Vector2(0, viewSize.y);
        wall[2].offset = new Vector2(-viewSize.x, 0);
        wall[3].offset = new Vector2(0, -viewSize.y);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
