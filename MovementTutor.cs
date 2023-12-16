using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTutor : MonoBehaviour
{
    public int movement=0; /* To change*/
    private int movCurrent=0;

    private Animator animator;
    public RuntimeAnimatorController[] movementController;

    void Start()
    {
        animator = GetComponent<Animator>();
        animator.runtimeAnimatorController = movementController[movement];
    }

    void Update()
    {
        if(movCurrent!=movement){
            animator.runtimeAnimatorController = movementController[movement];
            movCurrent=movement;
        }
        
    }
}
