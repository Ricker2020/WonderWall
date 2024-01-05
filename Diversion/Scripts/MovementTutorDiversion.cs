using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTutorDiversion : MonoBehaviour
{
    public int movCurrent=0; /* To change*/


    private Animator animator;
    public RuntimeAnimatorController[] movementController;

    void Start()
    {
        animator = GetComponent<Animator>();
        animator.runtimeAnimatorController = movementController[Variables_Diversion.instance.movement_tutor];
    }

    void Update()
    {
        if(movCurrent!=Variables_Diversion.instance.movement_tutor){
            movCurrent=Variables_Diversion.instance.movement_tutor;
            animator.runtimeAnimatorController = movementController[Variables_Diversion.instance.movement_tutor];
        }
        
    }
}
