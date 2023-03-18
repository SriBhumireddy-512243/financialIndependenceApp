using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using TMPro;

public class Valide : MonoBehaviour
{
    public TMP_Text text;
    public bool clicked = false;
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void textChange()
    {
        clicked = !clicked;
        if (clicked == true)
        {
            text.text = "Not Valid";

        }
        else
        {
            text.text = "";
        }
    }

}
