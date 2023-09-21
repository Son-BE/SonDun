using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Button gameStart;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject utilityBox;
    [SerializeField] private GameObject statusTop;
    // Start is called before the first frame update
    void Start()
    {
        gameStart.onClick.AddListener(GameStart);
    }

    private void GameStart()
    {
        player.SetActive(true);
        utilityBox.SetActive(true);
        statusTop.SetActive(true);
    }       
}
