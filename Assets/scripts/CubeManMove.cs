using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManMove : MonoBehaviour
{
    public Animator Ani;

    private string ANI_WAVE = "Wave";
    private string ANI_WALK = "Walk";
    private string ANI_IDLE = "Idle";

    void Update()
    {
        
        if (Input.GetKey(KeyCode.RightArrow)) //walk
        {
            Ani.Play(ANI_WALK);
        }
        else if (Input.GetKey(KeyCode.W)) //Wave
        {
            Ani.Play(ANI_WAVE);
        }
        else                        //Idle
        {
            Ani.Play(ANI_IDLE);
        }
    }
}
