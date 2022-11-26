using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToEndScreen : MonoBehaviour
{
    //Moves to ending scene
   public void LoadScreen()
    {
        SceneManager.LoadScene(3);
    }
}
