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
public class CalculateFinancialindependence : MonoBehaviour {
    public TMP_Text answer;
    string FILE_PATH1 = " ";
    string userName;
    float currentSavings;
    float investableAccounts;
    float retirementAccount;
    float annualExpenses;
    float safeWithdrawalRate;
    float yearlySavings;

    public void LoadUp()
    {
        if (System.IO.File.Exists(FILE_PATH1))
        {
            string[] lines = System.IO.File.ReadAllLines(FILE_PATH1);
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
        answer.text = "Check";
    }


    void Start()
    {
        FILE_PATH1 = Application.persistentDataPath + "/userinfo.txt";
        if (System.IO.File.Exists(FILE_PATH1))
        {
            string[] lines = System.IO.File.ReadAllLines(FILE_PATH1);
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
        answer.text = "Test";//userName;

    }

}
