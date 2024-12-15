using Unity.VisualScripting;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Enemy : MonoBehaviour
{
    public GameObject[] enemies = new GameObject[4];
    private BattleManager bm;
    private KnightBattle player;
    private bool isPlayerClose = false;
    
    void Awake()
    {
        bm = GameObject.Find("BattleManager").GetComponent<BattleManager>();
        player = GameObject.Find("Player").GetComponent<KnightBattle>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isPlayerClose) {
            Debug.Log("Player?????");
            bm.StartBattle(player.currentParty, enemies);
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            isPlayerClose = true;
        }
    }

    void OnTriggerExit2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            isPlayerClose = false;
        }
    }
}
