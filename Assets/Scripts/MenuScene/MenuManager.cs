using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
 
public class MenuManager : MonoBehaviour {
 
    public Toggle MultiplayerToggle;
 
    private void Start()
    {
        MultiplayerToggle.isOn = GameValues.IsMultiplayer;
    }
 
    public void PlayGame()
    {
        SceneManager.LoadScene("main");
    }
 
    public void SetMultiplayer(bool isOn)
    {
        GameValues.IsMultiplayer = isOn;
    }
}