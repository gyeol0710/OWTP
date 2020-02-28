using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyMove : MonoBehaviour
{
    Transform tr;

    void Start()
    {
        tr = GetComponent<Transform>();

        Destroy(this.gameObject, 2f);
    }

    void Update()
    {
        tr.Translate(Vector2.up * 0.05f);

        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, sr.color.a - 0.007f);
    }
}
