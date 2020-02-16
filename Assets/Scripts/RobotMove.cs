using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMove : MonoBehaviour
{
    Transform tr;
    float speed;
    void Start()
    {
        
    }

    void Update()
    {
        tr.Translate(Vector2.left * speed);
    }
}
