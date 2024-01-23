using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleTutorialTutor : MonoBehaviour
{
    public GameObject tutor;
    float scale_max = 0.4f;
    float scale_min = 0.1f;
    float scale_current;
    float cooldown = 2.0f;
    public GameObject nextStep;


    public float increment = 0.001f;

    void Start()
    {
        scale_current = tutor.transform.localScale.x;
        StartCoroutine(Tutor());
    }

    IEnumerator Tutor()
    {
        for (; scale_current > scale_min; scale_current -= increment)
        {
            tutor.transform.localScale = new Vector3(scale_current, scale_current, scale_current);
            yield return new WaitForSeconds(0.0001f);
        }
        yield return new WaitForSeconds(cooldown);
        tutor.transform.position = new Vector3(-8.0f, tutor.transform.position.y, tutor.transform.position.z);

        for (; scale_current < scale_max; scale_current += increment)
        {
            tutor.transform.localScale = new Vector3(scale_current, scale_current, scale_current);
            yield return new WaitForSeconds(0.0001f);
        }
        nextStep.SetActive(true);

    }
    
}
