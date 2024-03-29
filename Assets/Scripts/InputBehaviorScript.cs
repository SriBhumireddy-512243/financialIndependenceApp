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


public class InputBehaviorScript : MonoBehaviour
{
    //Text Field Variables
    public TMP_InputField field;
    public String[] calcInputs = { "Name", "Current Savings", "Investable Accounts", "Retirement Accounts", "Annual Expenses", "Safe WIthdrawal Rates", "Yearly Savings", " Press the Calculate Button" };
    public TMP_Text text;
    public TMP_Text descriptionText;
    public String[] descList = { "Input your name.", "Current Savings: total amount of money in your savings account.", "Investable accounts: the amount of money invested  in brokerage, stocks, etc.", "Retirement Account:  the amount of money in any retirement account you may have.", "Annual Expenses: what you spend in a year. (monthly expenses * 12).", "  Safe Withdrawal Rate: a minimum percentage of money that you will withdraw in retirement to cover your basic need expenses. The recommended percentage is 4%. Please enter a whole number.", "Yearly Savings: the amount of money you save each year." };
    public String[] descriptionList = { "Input your name.", "Current Savings: total amount of money in your savings.", "Investable accounts: the amount of money invested in brokerage, stocks, etc..", "Retirement Account: the amount of money in any retirement account you may have", "Annual Expenses: what you spend in a year.(monthly expenses *12)", "Safe Withdrawal Rate: a minimum percentage of money that will withdraw in retirement to cover your basic need expenses.The recommended perentage is 4%. Please enter a whole number.", "Yearly Savings: the amount of money you save each year.", "Press the Calculate Button " };
    public int i = 0;
    public String userInput = "";
    public string [,] merged = new string[2,2];
    



    //Calculate Button
    public Button calculateButton; 
    public TMP_Text buttonTestText;

    // New User creation 
    public String[] userCreation = {"", "", "", "", "", "", "", ""};
    
    public void createUser()
    {
        NewUser user = new NewUser(userCreation[0], float.Parse(userCreation[1]), float.Parse(userCreation[2]), float.Parse(userCreation[3]), float.Parse(userCreation[4]), int.Parse(userCreation[5]), float.Parse(userCreation[6]));
        
    }       

    public mergeArrays()
    {
        for(int i =0; i<calcInputs.Length();i++)
        {
            for(int j = 0; j<descList.Length();j++)
            {
                merged[i]][j] = [calcInputs[i]][descList[j]];
            }
        }
    }
    
    //File Creation
    public void Write2File()
    {
        string FILE_PATH = Application.persistentDataPath + "/userdata.txt";
        //StreamWriter sr = System.IO.File.CreateText(FILE_PATH);
        using (StreamWriter swriter = new StreamWriter(FILE_PATH))
        {
            swriter.Write("a");
            //sr.Write(userCreation[0] + userCreation[1] + userCreation[2] + userCreation[3] + userCreation[4] + userCreation[5] + userCreation[6]);//userCreation[0] + userCreation[1] + userCreation[2] + userCreation[3] + userCreation[4] + userCreation[5] + userCreation[6]);
            swriter.WriteLine(string.Join(" ", userCreation));
            swriter.WriteLine("Post string a");
            swriter.Close();
        }
    }

    public void WriteFileV2()
    {
        string FILE_PATH = Application.persistentDataPath + "/userdata.txt";

        using (FileStream fs = File.Create(FILE_PATH))
        {
            string s = userCreation[0];
            char[] ch = s.ToCharArray();
            byte[] info = new UTF8Encoding(true).GetBytes(ch);
            // Add some information to the file.
            fs.Write(info, 0, info.Length);
        }

    }
    public void updateUserCreation(int i)
    {
        string userInput = field.text;
        userCreation[i] = userInput;
    }

    public bool isInt(string s)
    {
        int result;
        if (int.TryParse(s,out result))
        {
            return true;
        }

        else
        {
            return false;
        }
    }



    public void fieldChange()
    {

        text.text = calcInputs[i];
        descriptionText.text = descriptionList[i];
        buttonTestText.text = "field change works";
        textUpdateFromUser();
        updateUserCreation(i);                                                                                                                                                                                                                                                                                               
        i++;
    }

    public void textUpdateFromUser()
    {
        userInput = field.text;
        userCreation[i] = field.text;
        field.text = "";
        Debug.Log(userInput+descriptionList[i]);
        //delete below line
        buttonTestText.text = field.text;
        if(i==6)
        {
            createUser();
            Write2File();
        }
    }
    // Start is called before the first frame update
    void Start()
    {

        text.text = calcInputs[0];
        descriptionText.text = "Input your Name.";
        i++;
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

