using System;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public GameObject[] players;
    public GameObject[] enemies;
    private bool isBattleActive = false;
    private Transform playerTransform;
    public Transform cameraTransform;
    public Transform playerStage;
    public Transform enemyStage;

    private KnightMovement playerMovement;

    void Awake() {
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();
        playerMovement = GameObject.Find("Player").GetComponent<KnightMovement>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cameraTransform.position = new Vector3(0,0,-10);
    }

    public void StartBattle(GameObject[] players, GameObject[] enemies) {
        
        if (!isBattleActive) {
            playerMovement.canMove = false;

            isBattleActive = true;
            cameraTransform.position = new Vector3(-25,-25,-10);
            this.players = players;
            this.enemies = enemies;

            setUpPlayers();
        }
    }

    private void setUpPlayers() {
        for (int i = 0; i < players.Length; i++) {
            if (players[i] != null) {
                switch (i)
                {
                    case 0:
                        Instantiate(players[i], playerStage);
                        break;
                }
            }
        }
    }

    public void EndBattle() {
        isBattleActive = false;
        playerMovement.canMove = true;
        cameraTransform.position = playerTransform.position;
        
        Array.Clear(players, 0, players.Length);
        Array.Clear(enemies, 0, players.Length);
        
        Debug.Log("Battle ended!");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
