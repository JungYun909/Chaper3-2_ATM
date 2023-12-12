using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.EventSystems.StandaloneInputModule;

public class Deposit : MonoBehaviour
{

    public int DepositMoney;
    public InputField MoneyInput;
    public GameObject FailPanel;

    private void Awake()
    {
        DepositMoney = 0;
    }

    void DepositCheck()
    {
        if (GameManager.I.Money >= DepositMoney)
        {
            GameManager.I.Banlance += DepositMoney;
            GameManager.I.Money -= DepositMoney;

        }

        else
        {
            FailPanel.SetActive(true);
            
        }
    }

    public void DepositBT1()
    {
        DepositMoney = 10000;
        DepositCheck();

    }

    public void DepositBT2()
    {
        DepositMoney = 30000;
        DepositCheck();
    }

    public void DepositBT3()
    {
        DepositMoney = 50000;
        DepositCheck();
    }

    public void DepositBT4()
    {
        DepositMoney = Convert.ToInt32(MoneyInput.GetComponent<InputField>().text);
        DepositCheck();
        MoneyInput.GetComponent<InputField>().text = "";
    }


}
