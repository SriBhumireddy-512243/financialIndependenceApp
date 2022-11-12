using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System;
public class NewUser : MonoBehaviour
{
    public class NewUserTemplate
    {
	public string userName;
	public float currentSavings;
	public float investableAccounts;
	public float retirementAccount;
	public float annualExpenses;
	public int safeWithdrawalRate;
	public float yearlySavings;
	
//constructor
	public NewUserTemplate(string name, float csavings, float iaccount, float raccount, float expenses, int rate, float ysavings)
	{
	   userName = name;
	   currentSavings = csavings;
           investableAccounts = iaccount;
	   retirementAccount = raccount;
	   annualExpenses = expenses;
	   safeWithdrawalRate = rate;
	   yearlySavings = ysavings;
	}	
// get methods
	public String getUserName()
	{
	   return name;
	}

	public float getCurrentSavings()
	{
	   return csavings;
	}

	public float getInvestableAccounts()
	{
	   return iaccount;
	}

	public float getRetirementAccounts()
	{
	   return raccount;
	}

	public float getAnnualExpenses()
	{
	   return expenses;
	}

	public int getSafeWithdrawalRate()
	{
	   return rate;
	}

	public float getYearlySavings()
	{
	   return ysavings;
	}

//set methods	
	public void setUserName(String n)
	{
	   name =n;
	}

	public void setCurrentSavings(float f)
	{
	   csavings = f;
	}

	public void setInvestableAccounts(float f)
	{
	   iaccount = f;
	}

	public void setRetirementAccounts(float f)
	{
	   raccount = f;
	}

	public void setAnnualExpenses(float f)
	{
	   expenses = f;
	}

	public void setSafeWithdrawalRate(int i)
	{
	   rate = i;
	}

	public void setYearlySavings(float f)
	{
	   ysavings =f;
	}

    }

	

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
