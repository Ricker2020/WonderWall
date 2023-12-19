using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateDoorTutorial : MonoBehaviour
{
    public GameObject door;
    bool cooldown = true;
    int position_data_questions=0;
    List<ObjectData> data_current;
    List<string> bad_answer; 
    float timeToCreate=13.0f; //10

    public int cant_questions;






    void Start()
    {
        data_current=new List<ObjectData>();
        data_current.Add(new ObjectData("Uno", "1"));
        data_current.Add(new ObjectData("Dos", "2"));
        data_current.Add(new ObjectData("Tres", "3"));
        data_current.Add(new ObjectData("Cuatro", "4"));
        cant_questions=data_current.Count;

        bad_answer=new List<string>();
        bad_answer.Add("2");
        bad_answer.Add("1");
        bad_answer.Add("4");
        bad_answer.Add("3");

    }

    // Update is called once per frame
    void Update()
    {
        if (cooldown && position_data_questions < cant_questions)
        {
            cooldown = false;
            Invoke("cooldown_activate", timeToCreate);
        }
        //FIN DE PARTIDA
        if (position_data_questions == cant_questions)
        {
            cooldown = false;
            cant_questions = +1;
        }

    }
    void cooldown_activate()
    {
        cooldown = true;
        GameObject instantiatedDoor = Instantiate(door);
        DoorAction doorScript = instantiatedDoor.GetComponent<DoorAction>();
        doorScript.text_question = data_current[position_data_questions].question;

        doorScript.speed = 2.0f;


        System.Random random2 = new System.Random();

        int randomIndex2 = random2.Next(0, 10);
        if (randomIndex2 < 5)
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
    }

}
