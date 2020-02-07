using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Work : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject() == false)
            {
                anim.SetTrigger("Click");
            }
        }
    }
}
