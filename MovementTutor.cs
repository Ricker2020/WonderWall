using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTutor : MonoBehaviour
{
    public int movCurrent=0; /* To change*/


    private Animator animator;
    public RuntimeAnimatorController[] movementController;

    void Start()
    {
        animator = GetComponent<Animator>();
        animator.runtimeAnimatorController = movementController[Variables_Game.instance.movement_tutor];
    }

    void Update()
    {
        if(movCurrent!=Variables_Game.instance.movement_tutor){
            movCurrent=Variables_Game.instance.movement_tutor;
            animator.runtimeAnimatorController = movementController[Variables_Game.instance.movement_tutor];
        }
        
    }
}
