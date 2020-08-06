using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotManager : MonoBehaviour
{
    Transform tr;
    public float Speed;
    SpriteRenderer sr;
    public static Animator Robot_anim;

    private bool RightOn;

    double MaxY;
    double MinY;

    void Start()
    {
        tr = GetComponent<Transform>();
        sr = GetComponent<SpriteRenderer>();
        Robot_anim = GetComponent<Animator>();
        RightOn = false;
        LoadAge();
        StartCoroutine(RobotMoving());

        MaxY = tr.position.y + 0.08;
        MinY = tr.position.y - 0.08;
    }

    void LoadAge()
    {
        if (TechManager.age_modern == true)
        {
            Robot_anim.SetBool("Age_Modern", true);
        }
        else if (TechManager.age_elec == true)
        {
            Robot_anim.SetBool("Age_Elec", true);
        }
        else if (TechManager.age_war == true)
        {
            Robot_anim.SetBool("Age_War", true);
        }
    }

    IEnumerator RobotMoving()
    {
        while(true)
        {
            if (RightOn == false)
            {
                sr.flipX = false;
                tr.Translate(Vector3.left * Speed * 0.01f);

                if (tr.position.x < -7.5)
                {
                    RightOn = true;
                }
            }
            else if (RightOn == true)
            {
                sr.flipX = true;
                tr.Translate(Vector3.right * Speed * 0.01f);

                if (tr.position.x > 7.5)
                {
                    RightOn = false;
                }
            }

            yield return new WaitForSeconds(0.02f);
        }
    }

    IEnumerator Robot_Modern_Ymoving()
    {
        while(true)
        {
            if (MaxY > tr.position.y)

            yield return new WaitForSeconds(0.04f);
        }
    }

    void Update()
    {
        
    }
}
