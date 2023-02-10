using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public TextMeshProUGUI nameText;


    public void AssignName(string name)
    {
        NameManager.Instance.playerName = name;
    }

    public void StartNew()
    {
        AssignName(nameText.text);
        SceneManager.LoadScene(1);
    }
}
