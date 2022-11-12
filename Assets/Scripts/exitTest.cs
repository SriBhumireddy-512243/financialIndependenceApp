using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class exitTest : MonoBehaviour
{
    [SerializeField] public Text filler;
    [SerializeField] public InputField field;

    
    string nameOfUser;
    public void Start()
    {
        filler.text = "Please input your name";
    }
    public void Update()
    {
        if (field.text != null)
        {
            
            filler.text = "The name you picked is:" + nameOfUser;
        }
    }
    public void changeText1()
    {
        
        filler.text = "The name you picked is:" + nameOfUser;
    }
 
   
  

}