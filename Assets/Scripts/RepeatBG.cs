﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBG : MonoBehaviour
{
    public float speed;
    public float startY;
    public float endY;

    private void Update() {
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        if (transform.position.y <= endY) {
            Vector2 pos = new Vector2(transform.position.x, startY);
            transform.position = pos;
        }
    }
}
