using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Withdraw : MonoBehaviour
{
    public int WithdrawMoney;
    public InputField MoneyInput;
    public GameObject FailPanel;

    private void Awake()
    {
        WithdrawMoney = 0;
    }

    void WithdrawCheck()
    {
        if (GameManager.I.Banlance >= WithdrawMoney)
        {
            GameManager.I.Banlance -= WithdrawMoney;
            GameManager.I.Money += WithdrawMoney;

        }

        else
        {
            FailPanel.SetActive(true);

        }
    }

    public void WithdrawBT1()
    {
        WithdrawMoney = 10000;
        WithdrawCheck();

    }

    public void WithdrawBT2()
    {
        WithdrawMoney = 30000;
        WithdrawCheck();
    }

    public void WithdrawBT3()
    {
        WithdrawMoney = 50000;
        WithdrawCheck();
    }

    public void WithdrawBT4()
    {
        WithdrawMoney = Convert.ToInt32(MoneyInput.GetComponent<InputField>().text);
        WithdrawCheck();
        MoneyInput.GetComponent<InputField>().text = "";
    }
}
