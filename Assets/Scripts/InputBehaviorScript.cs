using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using TMPro;
public class InputBehaviorScript : MonoBehaviour
{
    //Text Field Variables
    public TMP_InputField field;
    public String[] calcInputs = {"Name", "Current Savings", "Investable Accounts", "Retirement Accounts", "Annual Expenses", "Safe WIthdrawal Rates", "Yearly Savings", " Press the Calculate Button"};
    public TMP_Text text;
    public TMP_Text descriptionText;
    public String[] descList = {"Input your name.", "Current Savings: total amount of money in your savings account." , "Investable accounts: the amount of money invested  in brokerage, stocks, etc.", "Retirement Account:  the amount of money in any retirement account you may have.", "Annual Expenses: what you spend in a year. (monthly expenses * 12).", "  Safe Withdrawal Rate: a minimum percentage of money that you will withdraw in retirement to cover your basic need expenses. The recommended percentage is 4%. Please enter a whole number.", "Yearly Savings: the amount of money you save each year."}; 
    public String[] descriptionList = {"Input your name.", "Current Savings: total amount of money in your savings.", "Investable accounts: the amount of money invested in brokerage, stocks, etc..", "Retirement Account: the amount of money in any retirement account you may have", "Annual Expenses: what you spend in a year.(monthly expenses *12)", "Safe Withdrawal Rate: a minimum percentage of money that will withdraw in retirement to cover your basic need expenses.The recommended perentage is 4%. Please enter a whole number.", "Yearly Savings: the amount of money you save each year.", "Press the Calculate Button"};
    public int i =0;
    public void fieldChange()
    {

        text.text = calcInputs[i];
        descriptionText.text = descriptionList[i];
        i++;
    }
    // Start is called before the first frame update
    void Start(){

        text.text = calcInputs[0];
        descriptionText.text = "Input your Name.";
        i++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

