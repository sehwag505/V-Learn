using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{

    bool ispaused = false;
    public void oneto2()
    {
        SceneManager.LoadScene("2");
    }
    public void twoto2a()
    {
        SceneManager.LoadScene("2a");
    }

    public void twoto3()
    {
        SceneManager.LoadScene("3");
    }
    public void threeto4()
    {
        SceneManager.LoadScene("4");
    }
    public void threeto5()
    {
        SceneManager.LoadScene("5");
    }
    public void threeto6()
    {
        SceneManager.LoadScene("6");
    }
    public void threeto7()
    {
        SceneManager.LoadScene("7");
    }
    public void sevento8()
    {
        SceneManager.LoadScene("8");
    }
    public void eightto12()
    {
        SceneManager.LoadScene("12");
    }

    public void pausegame()
    {
        if (ispaused)
        {
            Time.timeScale = 1;
            ispaused = false;
        }
        else
        {
            Time.timeScale = 0;
            ispaused = true;
        }
    }

    public void scene14()
    {
        SceneManager.LoadScene("14");
    }
    public void scene13()
    {
        SceneManager.LoadScene("13");

    }
    public void scene11()
    {
        SceneManager.LoadScene("11");

    }
    public void scene09()
    {
        SceneManager.LoadScene("9");
    }
    public void scene03()
    {
        SceneManager.LoadScene("3");
    }
    public void scene10()
    {
        SceneManager.LoadScene("10");
    }








}
