using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class ThemesPlayer : MonoBehaviour
{
    public Button buttonTheme;
    public Button buttonLeft;
    public Button buttonRight;
    public Text text_view;

    public GameObject quantity;
    public Text details;

    int cant_themes = 0;
    int size_data = 0;



    //
    public Text description;

    List<ObjectTheme> data_current;
    ObjectTheme current_object;

    bool reload = true;

    void Start()
    {
        buttonLeft.onClick.AddListener(() => ChangeTheme(-1));
        buttonRight.onClick.AddListener(() => ChangeTheme(1));
        CurrentData();
        //text_view.text=SaveLoadData.ruteData();
    }

    void Update()
    {
        if (gameObject.activeSelf && reload)
        {
            Variables_Game.instance.changeFileThemes += 1;
            reload = false;
            CurrentData();
        }
    }

    void OnDisable()
    {
        reload = true;
    }

    void CurrentData()
    {
        cant_themes = 0;
        size_data = 0;
        string difficulty = Variables_Game.instance.difficulty;
        ObjectThemeContainer container = SaveLoadData.LoadThemes<ObjectThemeContainer>("FilesGame/Difficulty/" + difficulty, "themes" + difficulty);
        data_current = container.dataList;
        size_data = data_current.Count;
        if (size_data == 0)
        {
            quantity.SetActive(false);
            details.gameObject.SetActive(true);
        }
        else
        {
            text_view.text = data_current[0].title;
            if (description)
            {
                description.text = data_current[0].description;
            }
            current_object = data_current[0];
            quantity.SetActive(true);
            details.gameObject.SetActive(false);
        }
    }

    public void SelectTheme()
    {
        Variables_Game.instance.selectedTheme = current_object;
    }

    void ChangeTheme(int direction)
    {
        if (direction == -1)
        {
            if (cant_themes == 0)
            {
                cant_themes = size_data;
            }
            cant_themes -= 1;
        }
        else
        {
            if (cant_themes == size_data - 1)
            {
                cant_themes = -1;
            }
            cant_themes += 1;
        }

        text_view.text = data_current[cant_themes].title;
        if (description)
        {
            description.text = data_current[cant_themes].description;
        }

        current_object = data_current[cant_themes];
    }
}
