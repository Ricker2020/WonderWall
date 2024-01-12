using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Direction_Arrow : MonoBehaviour
{
    public GameObject arrow1;
    public GameObject arrow1_select;
    public GameObject arrow2;
    public GameObject arrow2_select;
    public GameObject arrow3;
    public GameObject arrow3_select;
    public GameObject arrow4;
    public GameObject arrow4_select;

    int direction_current = 0;



    void Update()
    {
        if (direction_current != Variables_Game.instance.direction_arrow)
        {
            direction_current = Variables_Game.instance.direction_arrow;
            unselected();
            switch (direction_current)
            {
                case 1:
                    arrow1_select.SetActive(true);
                    break;

                case 2:
                    arrow2_select.SetActive(true);
                    break;

                case 3:
                    arrow3_select.SetActive(true);
                    break;

                case 4:
                    arrow4_select.SetActive(true);
                    break;
            }
        }


    }

    void unselected()
    {
        if (arrow1_select)
        {
            arrow1_select.SetActive(false);
        }
        if (arrow2_select)
        {
            arrow2_select.SetActive(false);
        }
        if (arrow3_select)
        {
            arrow3_select.SetActive(false);
        }
        if (arrow4_select)
        {
            arrow4_select.SetActive(false);

        }




        if (arrow1)
        {
            arrow1.SetActive(true);
        }
        if (arrow2)
        {
            arrow2.SetActive(true);
        }
        if (arrow3)
        {
            arrow3.SetActive(true);
        }
        if (arrow4)
        {
            arrow4.SetActive(true);
        }





    }
}
