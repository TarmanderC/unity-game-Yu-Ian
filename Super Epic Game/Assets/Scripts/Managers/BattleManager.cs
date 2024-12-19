using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

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
    public TurnManager tm;


    public Transform playerSpawnPoint;
    public Transform enemySpawnPoint;
    public Vector3[] playerPositions;
    public Vector3[] enemyPositions;


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
            cameraTransform.position = new Vector3(-25,-26,-10);

            this.players = players;
            this.enemies = enemies;

            InitializeUnits(players, enemies);
        }
    }

    private void InitializeUnits(GameObject[] players, GameObject[] enemies) {
        for (int i = 0; i < players.Length; i++) {
                if (players[i] != null)
                {
                    GameObject player = Instantiate(players[i], playerPositions[i], Quaternion.identity);
                    player.transform.SetParent(playerSpawnPoint);
                }
            }

            for (int i = 0; i < enemies.Length; i++) {
                if (enemies[i] != null)
                {
                    GameObject enemy = Instantiate(enemies[i], enemyPositions[i], Quaternion.identity);
                    enemy.transform.SetParent(enemySpawnPoint);
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
