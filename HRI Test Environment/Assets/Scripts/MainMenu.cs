﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("main_menu");
        }
    }

    public void Dre_Hallway_Scene()
    {
        SceneManager.LoadScene("Dre_hallway_scene");
    }

    public void Hallway_Scene()
    {
        SceneManager.LoadScene("hallway_scene");
    }

    public void Room_Scene()
    {
        SceneManager.LoadScene("room_scene");
    }

    public void Dre_Room_Scene()
    {
        SceneManager.LoadScene("Dre_room_scene");
    }


    public void A_star_Room_Scene()
    {
        SceneManager.LoadScene("a_star2");
    }

    public void Menu_Scene()
    {
        SceneManager.LoadScene("main_menu");
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game!");
        Application.Quit();
    }

}
