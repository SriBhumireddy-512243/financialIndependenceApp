using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HometoExistingUser : MonoBehaviour
{
    //Home screen to New User screen
    public void LoadScreen()
    {
        SceneManager.LoadScene(5);
    }
}
