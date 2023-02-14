using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Wallet : MonoBehaviour
{
    public float coins;
    public TMP_Text cointext;

    public void collectcoins(float newAmount ) {

        coins += newAmount;
        cointext.text = "Money have = " + coins.ToString() + ".mill";

    }
    // Start is called before the first frame update
    void Start()
    {
        cointext.text = "Money have = " + coins.ToString() + ".mill";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
