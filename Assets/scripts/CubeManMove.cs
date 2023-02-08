using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManMove : MonoBehaviour
{
    [SerializeField] 
    private Animator playerAnimator;
    [SerializeField] 
    private float WalkSpeed;
    private float animationSpeed;

    private void Update()
    {
        float input = Input.GetAxisRaw("Horizontal");

        if (input > 0)
        {
            playerAnimator.SetFloat("WalkSpeed", Time.deltaTime);
        }
        if (input < 0)
        {
            playerAnimator.SetFloat("WalkSpeed", Time.deltaTime);
        }
    }
   
}
