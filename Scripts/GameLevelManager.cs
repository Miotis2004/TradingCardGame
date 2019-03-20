using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLevelManager : MonoBehaviour
{

    public Hero playerHero;
    public Hero enemyHero;

    public GameObject avatarPrefab;

    public Transform playerAvatarSpawn;
    public Transform enemyAvatarSpawn;

    public int currentTurn = 0;
    public int activeManaCrystals = 0;
    public GameObject[] manaCrystals;

    public Button endTurnButton;

    private void Start()
    {
        PlayerSetup();
        EnemySetup();

        OnTurnStart();
    }

    private void EnemySetup()
    {
        GameObject go = Instantiate(avatarPrefab, new Vector3(enemyAvatarSpawn.position.x, enemyAvatarSpawn.position.y, -1.5f), Quaternion.identity);
        HeroDisplay display = go.GetComponent<HeroDisplay>();
        display.HeroSetup(enemyHero);
    }

    private void PlayerSetup()
    {
        GameObject go = Instantiate(avatarPrefab, new Vector3(playerAvatarSpawn.position.x, playerAvatarSpawn.position.y, -1.5f), Quaternion.identity);
        HeroDisplay display = go.GetComponent<HeroDisplay>();
        display.HeroSetup(playerHero);
    }

    public void OnTurnStart()
    {
        currentTurn++;
        activeManaCrystals = currentTurn;

        if (activeManaCrystals >= 10)
        {
            activeManaCrystals = 10;
        }

        for (int i = 0; i < activeManaCrystals; i++)
        {
            manaCrystals[i].SetActive(true);
        }

        endTurnButton.gameObject.SetActive(true);
    }

    public void OnTurnEnd()
    {
        endTurnButton.gameObject.SetActive(false);
    }
}
