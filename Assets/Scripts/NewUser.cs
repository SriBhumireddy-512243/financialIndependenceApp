using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
public class NewUser
{
    
	public String userName;
	public float currentSavings;
	public float investableAccounts;
	public float retirementAccount;
	public float annualExpenses;
	public int safeWithdrawalRate;
	public float yearlySavings;
	
//constructor
	public NewUser(string name, float csavings, float iaccount, float raccount, float expenses, int rate, float ysavings)
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
	   return userName;
	}

	public float getCurrentSavings()
	{
	   return currentSavings;
	}

	public float getInvestableAccounts()
	{
	   return investableAccounts;
	}

	public float getRetirementAccounts()
	{
	   return retirementAccount;
	}

	public float getAnnualExpenses()
	{
	   return annualExpenses;
	}

	public int getSafeWithdrawalRate()
	{
	   return safeWithdrawalRate;
	}

	public float getYearlySavings()
	{
	   return yearlySavings;
	}

//set methods	
	public void setUserName(String n)
	{
	   userName =n;
	}

	public void setCurrentSavings(float f)
	{
	   currentSavings = f;
	}

	public void setInvestableAccounts(float f)
	{
	   investableAccounts = f;
	}

	public void setRetirementAccounts(float f)
	{
	   retirementAccount = f;
	}

	public void setAnnualExpenses(float f)
	{
	   annualExpenses = f;
	}

	public void setSafeWithdrawalRate(int i)
	{
	   safeWithdrawalRate = i;
	}

	public void setYearlySavings(float f)
	{
	   yearlySavings =f;
	}

}
	
