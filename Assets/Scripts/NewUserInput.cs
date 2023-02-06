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


public class NewUserInput : MonoBehaviour
{

    public TMP_Text infobox;
    public TMP_Text title;
    public TMP_InputField input;
    public TMP_Text icheck;
    int i = 0;
    String[] descList = { "Input your name.", "Current Savings: total amount of money in your savings account.", "Investable accounts: the amount of money invested  in brokerage, stocks, etc.", "Retirement Account:  the amount of money in any retirement account you may have.", "Annual Expenses: what you spend in a year. (monthly expenses * 12).", "  Safe Withdrawal Rate: a minimum percentage of money that you will withdraw in retirement to cover your basic need expenses. The recommended percentage is 4%. Please enter a whole number.", "Yearly Savings: the amount of money you save each year." };
    String[] titleList = { "Name", "Current Savings", "Investable Accounts", "Retirement Accounts", "Annual Expenses", "Safe WIthdrawal Rates", "Yearly Savings", " Press the Calculate Button" };
    String[] userInfo = { "", "", "", "", "", "", "", "" };
    public NewUser user = new NewUser(" ", (float)0.0, (float)0.0, (float)0.0, (float)0.0, 0, (float)0.0);

    // Methods to run when Inputfield on end edit String
    public void infoboxUpdate()
    {
        infobox.text = descList[i];
    }
    public void iUpdate()
    {
        user.setUserName(userInfo[0]);
        i++;
        if (i == 1)
        {
            user.setCurrentSavings(float.Parse(userInfo[1]));
            icheck.text = "i + userInfo[i];";
        }
        if (i == 2)
        {
            user.setInvestableAccounts(float.Parse(userInfo[2]));
            icheck.text = "i + userInfo[i];";
        }
        if (i == 3)
        {
            user.setRetirementAccounts(float.Parse(userInfo[4]));
            icheck.text = i + userInfo[i];
        }
        if (i == 5)
        {
            user.setSafeWithdrawalRate(int.Parse(userInfo[5]));
            icheck.text = i + userInfo[i];
        }
        if (i == 6)
        {
            user.setYearlySavings(float.Parse(userInfo[6]));
            StreamWriter sr = new StreamWriter(Application.persistentDataPath + "/" + userInfo[0] + "financialTest.txt");
            sr.WriteLine(user.getUserName());
            sr.Close();
            icheck.text = i + userInfo[i];
        }
    }

    public void titleUpdate()
    {
        title.text = titleList[i];
    }
    public void userInfoStringUpdate()
    {
        userInfo[i] = input.text;
    }
    public void WriteToFile()
    {


        string FILE_PATH = Application.persistentDataPath + "/" + userInfo[0] + ".txt";
        StreamWriter sr = new StreamWriter(FILE_PATH);
        for (int i = 0; i < userInfo.Length; i++)
        {
            sr.WriteLine(userInfo[i]);
        }
        sr.Close();
    }





    // User Creation and calculation
    public void createUser()
    {
        NewUser user = new NewUser(userInfo[0], float.Parse(userInfo[1]), float.Parse(userInfo[2]), float.Parse(userInfo[3]), float.Parse(userInfo[4]), int.Parse(userInfo[5]), float.Parse(userInfo[6]));
        StreamWriter sr = new StreamWriter(Application.persistentDataPath + "/" + userInfo[0] + "financialTest.txt");
        sr.WriteLine(user.getUserName());
    }




    // Start is called before the first frame update
    void Start()
    {
        infobox.text = "Input your name.";
        title.text = " Name";
        i++;
    }

    // Update is called once per frame
    void Update()
    {


    }
}

































/**
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


public class NewUserInput : MonoBehaviour
{

    public TMP_Text infobox;
    public TMP_Text title;
    public TMP_InputField input;
    public TMP_Text icheck;
    int i = 0;
    String[] descList = {"Input your name.", "Current Savings: total amount of money in your savings account." , "Investable accounts: the amount of money invested  in brokerage, stocks, etc.", "Retirement Account:  the amount of money in any retirement account you may have.", "Annual Expenses: what you spend in a year. (monthly expenses * 12).", "  Safe Withdrawal Rate: a minimum percentage of money that you will withdraw in retirement to cover your basic need expenses. The recommended percentage is 4%. Please enter a whole number.", "Yearly Savings: the amount of money you save each year."}; 
    String[] titleList = {"Name", "Current Savings", "Investable Accounts", "Retirement Accounts", "Annual Expenses", "Safe WIthdrawal Rates", "Yearly Savings", " Press the Calculate Button"};
    String[] userInfo = {"", "", "", "", "", "", "", ""};
    public NewUser user = new NewUser(" ", (float) 0.0,(float) 0.0,(float) 0.0,(float) 0.0, 0,(float) 0.0);

    // Methods to run when Inputfield on end edit String
    public void infoboxUpdate()
    {
        infobox.text = descList[i];
    }
    public void iUpdate()
    {
        user.setUserName(userInfo[0]);
        i++;
        if(i==1)
        {
            user.setCurrentSavings(float.Parse(userInfo[1]));
            icheck.text = "i + userInfo[i];";
        }
        if(i==2)
        {
            user.setInvestableAccounts(float.Parse(userInfo[2]));
            icheck.text = "i + userInfo[i];";
        }
        if(i==3)
        {
            user.setRetirementAccounts(float.Parse(userInfo[4]));
            icheck.text = i + userInfo[i];
        }
        if(i==5)
        {
            user.setSafeWithdrawalRate(int.Parse(userInfo[5]));
            icheck.text = i + userInfo[i];
        }
        if(i==6)
        {
            user.setYearlySavings(float.Parse(userInfo[6]));
            StreamWriter sr = new StreamWriter(Application.persistentDataPath + "/" + userInfo[0]+ "financialTest.txt");
            sr.WriteLine(user.getUserName());
            sr.Close();
            icheck.text = i + userInfo[i];
        }
    }

    public void titleUpdate()
    {
        title.text = titleList[i];
    }
    public void userInfoStringUpdate()
    {
        userInfo[i] = input.text;WriteToFile
    }
    public void ()
    {
        string FILE_PATH = Application.persistentDataPath + "/" + userInfo[0] + ".txt";
        StreamWriter sr = new StreamWriter(FILE_PATH);
        for (int i = 0; i<userInfo.Length; i++)
        {
            sr.WriteLine(userInfo[i]);
        }
        sr.Close();
        /*
        string FILE_PATH = Application.persistentDataPath + "/" + userInfo[0]+ ".txt";
        //StreamWriter sr = System.IO.File.CreateText(FILE_PATH);
        StreamWriter sr = new StreamWriter(FILE_PATH);
        //sr.WriteLine("Checking");
        sr.WriteLine(userInfo[0] + "\n" + userInfo[1] + "\n" + userInfo[2] + "\n" + userInfo[3] + "\n" + userInfo[4] + "\n" + userInfo[5] + "\n" + userInfo[6] + "\n" + userInfo[7]);
        sr.Close();
        
    }

    



    // User Creation and calculation
     public void createUser()
    {
        NewUser user = new NewUser(userInfo[0], float.Parse(userInfo[1]), float.Parse(userInfo[2]), float.Parse(userInfo[3]), float.Parse(userInfo[4]), int.Parse(userInfo[5]), float.Parse(userInfo[6]));
        StreamWriter sr = new StreamWriter(Application.persistentDataPath + "/" + userInfo[0]+ "financialTest.txt");
        sr.WriteLine(user.getUserName());
    } 

    


    // Start is called before the first frame update
    void Start()
    {
        infobox.text = "Input your name.";
        title.text = " Name";
        i++;
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
