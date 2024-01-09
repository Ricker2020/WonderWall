using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionCanvasTutorial : MonoBehaviour
{
    float move=6.0f;
    public GameObject tutor;
    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;
    public GameObject cube4;

    void Start()
    {
        if(Variables_Game.instance.opcion_camera==0){
            transform.position=new Vector3(transform.position.x, transform.position.y,transform.position.z+move);
            tutor.transform.position=new Vector3(tutor.transform.position.x, tutor.transform.position.y, tutor.transform.position.z+move);
            cube1.transform.position=new Vector3(cube1.transform.position.x, cube1.transform.position.y, cube1.transform.position.z-move+0.5f);
            cube2.transform.position=new Vector3(cube2.transform.position.x, cube2.transform.position.y, cube2.transform.position.z-move+0.5f);
            cube3.transform.position=new Vector3(cube3.transform.position.x, cube3.transform.position.y, cube3.transform.position.z-move+0.5f);
            cube4.transform.position=new Vector3(cube4.transform.position.x, cube4.transform.position.y, cube4.transform.position.z-move+0.5f);

        }
        
    }
}
