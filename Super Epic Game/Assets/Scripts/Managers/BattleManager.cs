using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public List<GameObject> players;
    public List<GameObject> enemies;
    private bool isBattleActive = false;
    private Transform playerTransform;
    public Transform cameraTransform;

    void Awake() {
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cameraTransform.position = new Vector3(0,0,-10);
    }

    public void StartBattle(List<GameObject> players, List<GameObject> enemies) {
        if (!isBattleActive) {
            isBattleActive = true;
            cameraTransform.position = new Vector3(-25,-25,-10);
            this.players = players;
            this.enemies = enemies;
        }
    }

    public void EndBattle() {
        isBattleActive = false;
        cameraTransform.position = playerTransform.position;
        players.Clear();
        enemies.Clear();
        Debug.Log("Battle ended!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
