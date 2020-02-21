using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotManager : MonoBehaviour
{
    Transform tr;
    public float Speed;

    public Sprite INDRobot01L;
    public Sprite INDRobot01R;
    public Sprite INDRobot02L;
    public Sprite INDRobot02R;
    public Sprite INDRobot03L;
    public Sprite INDRobot03R;
    public Sprite INDRobot04L;
    public Sprite INDRobot04R;
    public Sprite INDRobot05L;
    public Sprite INDRobot05R;
    public Sprite INDRobot06L;
    public Sprite INDRobot06R;
    public Sprite INDRobot07L;
    public Sprite INDRobot07R;
    public Sprite INDRobot08L;
    public Sprite INDRobot08R;
    public Sprite INDRobot09L;
    public Sprite INDRobot09R;
    public Sprite INDRobot10L;
    public Sprite INDRobot10R;
    static Sprite currentRobotL;
    static Sprite currentRobotR;

    private SpriteRenderer RobotRenderer;
    private bool RightOn;

    

    void Start()
    {
        tr = GetComponent<Transform>();
        RobotRenderer = gameObject.GetComponent<SpriteRenderer>();
        currentRobotL = INDRobot01L;
        currentRobotR = INDRobot01R;
        RobotRenderer.sprite = currentRobotL;
        RightOn = false;
    }

    void Update()
    {
        if (RightOn == false)
        {
            RobotRenderer.sprite = currentRobotL;
            tr.Translate(Vector3.left * Speed * 0.01f);

            if (tr.position.x < -7.5)
            {
                RightOn = true;
            }
        }

        else if (RightOn == true)
        {
            RobotRenderer.sprite = currentRobotR;
            tr.Translate(Vector3.right * Speed * 0.01f);

            if (tr.position.x > 7.5)
            {
                RightOn = false;
            }
        }
    }
}
