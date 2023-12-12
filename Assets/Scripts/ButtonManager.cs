using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject depositBT;
    public GameObject withdrawBT;
    public GameObject button;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void DepositBT()
    {
        
        depositBT.SetActive(true);
        button.SetActive(false);

    }

    public void WithdrawBT()
    {
        
        withdrawBT.SetActive(true);
        button.SetActive(false);

    }

}
