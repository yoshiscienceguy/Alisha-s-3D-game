using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Wallet : MonoBehaviour
{
    public float coins;
    public TMP_Text cointext;

    public void collectcoins(float newAmount)
    {

        coins += newAmount;
        if (coins >= 11111) {

            SceneManager.LoadScene("SHEEPY GOOD WIN SCENE");
        }
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
