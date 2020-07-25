using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class navigation_back : MonoBehaviour
{
    public string scene_name = "mainScene";
    public void back()
    {
        SceneManager.LoadScene(scene_name);
    }
}
