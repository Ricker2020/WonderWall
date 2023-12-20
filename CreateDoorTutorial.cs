using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateDoorTutorial : MonoBehaviour
{
    public GameObject door;
    bool cooldown = true;
    int position_data_questions = 0;
    List<ObjectData> data_current;
    List<string> bad_answer;
    public int cant_questions;

    public float cooldownTime = 7.0f;


    void Start()
    {
        data_current = new List<ObjectData>();
        data_current.Add(new ObjectData("¿Cúal es el número Uno?", "1"));
        data_current.Add(new ObjectData("¿Cúal es el número Dos?", "2"));
        data_current.Add(new ObjectData("¿Cúal es el número Tres?", "3"));
        data_current.Add(new ObjectData("¿Cúal es el número Cuatro?", "4"));
        cant_questions = data_current.Count;

        bad_answer = new List<string>();
        bad_answer.Add("5");
        bad_answer.Add("6");
        bad_answer.Add("7");
        bad_answer.Add("8");

    }

    // Update is called once per frame
    void Update()
    {
        if (cooldown && position_data_questions < cant_questions)
        {
            cooldown = false;

            StartCoroutine(cooldown_activate());
    
        }
        //FIN DE PARTIDA
        if (position_data_questions == cant_questions)
        {
            cooldown = false;
            cant_questions = +1;
        }

    }
    IEnumerator cooldown_activate()
    {

        GameObject instantiatedDoor = Instantiate(door);
        DoorAction doorScript = instantiatedDoor.GetComponent<DoorAction>();
        doorScript.text_question = data_current[position_data_questions].question;
        doorScript.speed = 0.5f;

        if (position_data_questions == 1 || position_data_questions == 3)
        {
            doorScript.text_answer1 = data_current[position_data_questions].answer;
            doorScript.text_answer2 = bad_answer[position_data_questions];
            doorScript.position_correct = 1;

        }
        else
        {
            doorScript.text_answer1 = bad_answer[position_data_questions];
            doorScript.text_answer2 = data_current[position_data_questions].answer;
            doorScript.position_correct = 2;
        }
        position_data_questions += 1;
        //progressBar.UpdateProgressBar(position_data_questions, cant_questions);

        yield return new WaitForSeconds(cooldownTime);
        cooldown = true;

    }

}
