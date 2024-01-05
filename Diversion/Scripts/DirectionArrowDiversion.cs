using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionArrowDiversion : MonoBehaviour
{
    public GameObject arrow1;
    public GameObject arrow2;
    public GameObject arrow3;
    public GameObject arrow4;

    int direction_current = 0;


    void Update()
    {
        if (direction_current != Variables_Diversion.instance.direction_arrow)
        {
            direction_current = Variables_Diversion.instance.direction_arrow;
            unselected();
            switch (direction_current)
            {
                case 1:
                    arrow1.SetActive(true);
                    break;

                case 2:
                    arrow2.SetActive(true);
                    break;

                case 3:
                    arrow3.SetActive(true);
                    break;

                case 4:
                    arrow4.SetActive(true);
                    break;
            }
        }


    }

    void unselected()
    {
        arrow1.SetActive(false);
        arrow2.SetActive(false);
        arrow3.SetActive(false);
        arrow4.SetActive(false);

    }
}
