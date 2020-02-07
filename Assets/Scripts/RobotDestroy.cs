using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotDestroy : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (GameManager.robot == 1)
        {
            Destroy(this.gameObject);
        }
    }
}
