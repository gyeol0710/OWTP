using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FrogControll : MonoBehaviour
{
    AudioSource Frog_Effect;
    Animator Frog_Anim;
    Transform Frog_tr;
    static public SpriteRenderer Frog_sr;
    static public BoxCollider2D Frog_bc2d;

    float MaxX;
    float MinX;
    float MaxY;
    float MinY;

    void Awake()
    {
        Frog_Effect = this.GetComponent<AudioSource>();
        Frog_Anim = this.GetComponent<Animator>();
        Frog_tr = this.GetComponent<Transform>();
        Frog_sr = this.GetComponent<SpriteRenderer>();
        Frog_bc2d = this.GetComponent<BoxCollider2D>();
    }

    void Start()
    {
        MaxX = 2.7f;
        MinX = -2.7f;
        MaxY = 0.2f;
        MinY = -3f;

        StartCoroutine(Frog_Jump());
        StartCoroutine(Frog_Z());
        //StartCoroutine(Frog_Scale());
    }

    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Frog_Effect.Play();
    }

    IEnumerator Frog_Jump()
    {
        while(true)
        {
            Frog_Anim.SetTrigger("Jump");

            StartCoroutine(Frog_Move());

            yield return new WaitForSeconds(2f);
        }
    }

    IEnumerator Frog_Move()
    {
        int i = 0;
        int j = 7;
        int R_1 = 0;
        int R_2 = 0;
        bool RightOn = false;
        bool UpOn = false;

        if((Frog_tr.position.x - (float)MinX >= 1.5f) && ((float)MaxX - Frog_tr.position.x >= 1.5f))
        {
            R_1 = Random.Range(0, 2);
            if (R_1 == 1)
            {
                RightOn = true;
                Frog_sr.flipX = true;
            }
            else
            {
                Frog_sr.flipX = false;
            }
        }
        else if(Frog_tr.position.x - (float)MinX <= 1.5f)
        {
            RightOn = true;
            Frog_sr.flipX = true;
        }
        else
        {
            Frog_sr.flipX = false;
        }

        if ((Frog_tr.position.y - (float)MinY >= 0.5f) && ((float)MaxY - Frog_tr.position.y >= 0.5f))
        {
            R_2 = Random.Range(0, 2);
            if (R_2 == 1)
            {
                UpOn = true;
            }
        }
        else if (Frog_tr.position.y - (float)MinY <= 0.5f)
        {
            UpOn = true;
        }


        yield return new WaitForSeconds(0.12f);

        while (RightOn == false && UpOn == false)
        {
            if (i < 9)
            {
                Frog_tr.Translate(Vector3.left * 0.007f * j);
                Frog_tr.Translate(Vector3.up * 0.003f * j);
                j++;
            }
            else if (i < 18)
            {
                Frog_tr.Translate(Vector3.left * 0.007f * j);
                Frog_tr.Translate(Vector3.down * 0.007f * j);
                j--;
            }
            else
            {
                yield break;
            }
            i++;

            yield return new WaitForSeconds(0.02f);
        }

        while (RightOn == true && UpOn == false)
        {
            if (i < 9)
            {
                Frog_tr.Translate(Vector3.right * 0.007f * j);
                Frog_tr.Translate(Vector3.up * 0.003f * j);
                j++;
            }
            else if (i < 18)
            {
                Frog_tr.Translate(Vector3.right * 0.007f * j);
                Frog_tr.Translate(Vector3.down * 0.007f * j);
                j--;
            }
            else
            {
                yield break;
            }
            i++;

            yield return new WaitForSeconds(0.02f);
        }

        while (RightOn == false && UpOn == true)
        {
            if (i < 9)
            {
                Frog_tr.Translate(Vector3.left * 0.007f * j);
                Frog_tr.Translate(Vector3.up * 0.007f * j);
                j++;
            }
            else if (i < 18)
            {
                Frog_tr.Translate(Vector3.left * 0.007f * j);
                Frog_tr.Translate(Vector3.down * 0.003f * j);
                j--;
            }
            else
            {
                yield break;
            }
            i++;

            yield return new WaitForSeconds(0.02f);
        }

        while (RightOn == true && UpOn == true)
        {
            if (i < 9)
            {
                Frog_tr.Translate(Vector3.right * 0.007f * j);
                Frog_tr.Translate(Vector3.up * 0.007f * j);
                j++;
            }
            else if (i < 18)
            {
                Frog_tr.Translate(Vector3.right * 0.007f * j);
                Frog_tr.Translate(Vector3.down * 0.003f * j);
                j--;
            }
            else
            {
                yield break;
            }
            i++;

            yield return new WaitForSeconds(0.02f);
        }
    }
    /*
    IEnumerator Frog_Scale()
    {
        float Xscale;
        float Yscale;
        float CurY;
        while (true)
        {
            CurY = Frog_tr.position.y;
            Xscale = 0.6f * (0.65f + (0.35f * ((MaxY - CurY) / (MaxY - MinY))));
            Yscale = 0.6f * (0.65f + (0.35f * ((MaxY - CurY) / (MaxY - MinY))));

            Frog_tr.localScale = new Vector2(Xscale, Yscale);
            yield return new WaitForSeconds(0.1f);
        }
    }*/

    IEnumerator Frog_Z()
    {
        float WantZ = 0;
        while (true)
        {
            if(0.17 <= Frog_tr.position.y)
            {
                WantZ = 1.01f;
                Frog_tr.position = new Vector3(Frog_tr.position.x, Frog_tr.position.y, WantZ);
            }
            else if(-0.38 <= Frog_tr.position.y)
            {
                WantZ = 0.99f;
                Frog_tr.position = new Vector3(Frog_tr.position.x, Frog_tr.position.y, WantZ);
            }
            else if (-0.93 <= Frog_tr.position.y)
            {
                WantZ = 0.97f;
                Frog_tr.position = new Vector3(Frog_tr.position.x, Frog_tr.position.y, WantZ);
            }
            else if (-1.48 <= Frog_tr.position.y)
            {
                WantZ = 0.95f;
                Frog_tr.position = new Vector3(Frog_tr.position.x, Frog_tr.position.y, WantZ);
            }
            else if (-2.03<= Frog_tr.position.y)
            {
                WantZ = 0.93f;
                Frog_tr.position = new Vector3(Frog_tr.position.x, Frog_tr.position.y, WantZ);
            }
            else if (-2.58 <= Frog_tr.position.y)
            {
                WantZ = 0.91f;
                Frog_tr.position = new Vector3(Frog_tr.position.x, Frog_tr.position.y, WantZ);
            }
            else if (-3.13 <= Frog_tr.position.y)
            {
                WantZ = 0.89f;
                Frog_tr.position = new Vector3(Frog_tr.position.x, Frog_tr.position.y, WantZ);
            }

            yield return new WaitForSeconds(0.2f);
        }
    }
}
