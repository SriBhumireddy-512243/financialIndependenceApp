using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
public class existingUser {
    
	public String userName;
	public float currentSavings;
	public float investableAccounts;
	public float retirementAccount;
	public float annualExpenses;
	public int safeWithdrawalRate;
	public float yearlySavings;
	public String txtFileName;

	// Load Method
	public void Load()
	{
		txtFileName = "userdata";
		string FILE_PATH = Application.persistentDataPath + "/" + txtFileName + ".txt";

		if (System.IO.File.Exists(FILE_PATH))
		{
			string[] lines = System.IO.File.ReadAllLines(FILE_PATH);
			userName = lines[0];
			currentSavings = float.Parse(lines[1]);
			investableAccounts = float.Parse(lines[2]);
			retirementAccount = float.Parse(lines[3]);
			annualExpenses = float.Parse(lines[4]);
			safeWithdrawalRate = int.Parse(lines[5]);
			yearlySavings = float.Parse(lines[6]);
		}
		else
		{
			Debug.Log("File not found");
		}
	}
	//constructor
	public existingUser(String name, float csavings, float iaccount, float raccount, float expenses, int rate, float ysavings, String tname)
	{
	   userName = name;
	   currentSavings = csavings;
       investableAccounts = iaccount;
	   retirementAccount = raccount;
	   annualExpenses = expenses;
	   safeWithdrawalRate = rate;
	   yearlySavings = ysavings;
	   txtFileName = tname;
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
	
	public String getTxtFileName()
	{
	   return txtFileName;
	}

//set methods	
	public void setUserName(String n)
	{
	   userName = n;
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
	
	public void setTxtFileName(String n)
	{
	   txtFileName =n;
	}

}

	


