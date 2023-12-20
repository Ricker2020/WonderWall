using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Round1_Tutorial : MonoBehaviour
{

    public GameObject door;
    public ObjectData data_current;
    public string bad_answer;

    public float cooldownTime = 3.0f;
    public float speedDoor = 1.2f;
    public int position_data_questions = 1;
    public Text textHelp;
    public string text_answer;
    public GameObject nextStep;



    void Start()
    {
        Variables_Game.instance.status = "Start";
        StartCoroutine(cooldown_activate());
    }


    IEnumerator cooldown_activate()
    {
        textHelp.text = text_answer;


        GameObject instantiatedDoor = Instantiate(door);
        DoorAction doorScript = instantiatedDoor.GetComponent<DoorAction>();
        doorScript.text_question = data_current.question;
        doorScript.speed = speedDoor;

        if (position_data_questions == 1)
        {
            doorScript.text_answer1 = data_current.answer;
            doorScript.text_answer2 = bad_answer;
            doorScript.position_correct = 1;

        }
        else
        {
            doorScript.text_answer1 = bad_answer;
            doorScript.text_answer2 = data_current.answer;
            doorScript.position_correct = 2;
        }


        yield return new WaitForSeconds(cooldownTime);
        if (nextStep)
        {
            nextStep.gameObject.SetActive(true);
        }
        gameObject.SetActive(false);


    }

}
