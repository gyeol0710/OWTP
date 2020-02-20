using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotManager : MonoBehaviour
{
    public Sprite RobotL;
    public Sprite RobotR;
    private SpriteRenderer RobotRenderer;

    Transform tr;
    public float Speed;

    void Start()
    {
        tr = GetComponent<Transform>();
        RobotRenderer = gameObject.GetComponent<SpriteRenderer>();
        RobotRenderer.sprite = RobotL;
    }

    void Update()
    {
        tr.Translate(Vector3.left * Speed);
    }
}
