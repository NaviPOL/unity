using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Napis : MonoBehaviour
{
    public Text someText;

    void Start()
    {
        someText = GetComponent<Text>();
    }

    void Update()
    {
		someText.text = "Życie: " + Toolbox.Instance.zycie.ToString() + "\nAnumicja: "  + Toolbox.Instance.amunicja.ToString()  + "\nPunkty: "  + Toolbox.Instance.punkty.ToString();
    }
}