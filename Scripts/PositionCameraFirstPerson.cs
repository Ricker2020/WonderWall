using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionCameraFirstPerson : MonoBehaviour
{
    
    public GameObject player;
    public GameObject model;
    void Start()
    {
      model.SetActive(false);
    }

 
    void Update()
    {
      transform.position=new Vector3(player.transform.position.x,(float)0.8,transform.position.z);
        
    }
}
