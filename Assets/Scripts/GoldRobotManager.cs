using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GoldRobotManager : MonoBehaviour
{
    Transform tr;
    public float Speed;
    SpriteRenderer sr;
    BoxCollider2D bc2d;
    public Animator Robot_anim;
    public GameObject AD_Panel;

    private bool RightOn;
    private bool DownOn;

    static public int remain_time_AD;
    static public int ticket_AD;

    public Text text_remain_time_AD;
    public Text text_ticket_AD;
    public Text text_InfoEffectMinutes_AD;
    public Text text_InfoRemainEffect_AD;

    double MaxY;
    double MinY;

    void Start()
    {
        tr = GetComponent<Transform>();
        sr = GetComponent<SpriteRenderer>();
        bc2d = GetComponent<BoxCollider2D>();
        Robot_anim = GetComponent<Animator>();
        LoadAge();
        StartCoroutine(RobotMoving());
        StartCoroutine(InfoAD());
        // StartCoroutine(Robot_Modern_Ymoving());
        StartCoroutine(Robot_Age());
        MaxY = tr.position.y + 0.05;
        MinY = tr.position.y - 0.05;
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

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0) && !IsPointerOverUIObject() && GameManager.robotLevel > 20)
        {
            AD_Panel.SetActive(true);
        }
    }

    static public IEnumerator ChargingAD()
    {
        remain_time_AD -= MessageManager.TimeDif;
        if (remain_time_AD >= 601)
        {
            remain_time_AD = 600;
        }
        else if (remain_time_AD <= -600)
        {
            remain_time_AD = 600;
            ticket_AD = 2;
        }
        else if (remain_time_AD >= -599 && remain_time_AD <= 0)
        {
            if (ticket_AD == 0)
            {
                ticket_AD++;
                remain_time_AD += 600;
            }
            else if (ticket_AD == 1)
            {
                ticket_AD = 2;
                remain_time_AD = 600;
            }
            else if (ticket_AD >= 2)
            {
                ticket_AD = 2;
                remain_time_AD = 600;
            }
        }

        if (ticket_AD >= 2)
        {
            ticket_AD = 2;
            remain_time_AD = 600;
        }

        if (ticket_AD < 0)
        {
            ticket_AD = 0;
            remain_time_AD = 600;
        }

        while (true)
        {
            if (ticket_AD < 2)
            {
                remain_time_AD--;
            }

            if (remain_time_AD <= 0)
            {
                if(ticket_AD <=2)
                {
                    ticket_AD++;
                }
                remain_time_AD = 600;
            }
            yield return new WaitForSeconds(1f);
        }
    }

    IEnumerator RobotMoving()
    {
        while (true)
        {
            if (RightOn == false)
            {
                sr.flipX = false;
                tr.Translate(Vector3.left * Speed * 0.01f);

                if (tr.position.x < -4.5)
                {
                    RightOn = true;
                }
            }
            else if (RightOn == true)
            {
                sr.flipX = true;
                tr.Translate(Vector3.right * Speed * 0.01f);

                if (tr.position.x > 4.5)
                {
                    RightOn = false;
                }
            }

            yield return new WaitForSeconds(0.02f);
        }
    }

    IEnumerator Robot_Modern_Ymoving()
    {
        while (true)
        {
            if (TechManager.age_modern == true)
            {
                break;
            }

            yield return new WaitForSeconds(2f);
        }

        while (true)
        {
            if (DownOn == false)
            {
                tr.Translate(Vector3.up * 0.007f);

                if (tr.position.y > MaxY)
                {
                    DownOn = true;
                }
            }
            else if (DownOn == true)
            {
                tr.Translate(Vector3.down * 0.007f);

                if (tr.position.y < MinY)
                {
                    DownOn = false;
                }
            }

            yield return new WaitForSeconds(0.04f);
        }
    }

    IEnumerator Robot_Age()
    {
        while (true)
        {
            if(GameManager.robotLevel > 20)
            {
                sr.enabled = true;
                bc2d.enabled = true;
            }


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

            yield return new WaitForSeconds(1.5f);
        }
    }

    IEnumerator InfoAD()
    {
        while(true)
        {
            int min = remain_time_AD / 60;
            int sec = remain_time_AD % 60;
            text_remain_time_AD.text = min + ":" + sec.ToString("D2") + " 뒤 충전";
            text_ticket_AD.text = "남은 횟수 : " + ticket_AD + "/2";
            text_InfoEffectMinutes_AD.text = "1분간";
            if (ProductManager.Prod_S02_Level > 0)
            {
                text_InfoEffectMinutes_AD.text = "2분간";
            }
            text_InfoRemainEffect_AD.text = GameManager.AdEffectRemain.ToString();
            if(GameManager.AdEffectRemain <= 0)
            {
                text_InfoRemainEffect_AD.text = "";
            }
            yield return new WaitForSeconds(1f);
        }
    }

    private bool IsPointerOverUIObject()
    {
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
        eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
        return results.Count > 0;
    }
}