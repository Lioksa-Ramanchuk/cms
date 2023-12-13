using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void LoadFirstScene()
    {
        SceneManager.LoadScene("T1");
    }
    public void LoadSecondScene()
    {
        SceneManager.LoadScene("T2");
    }
}
