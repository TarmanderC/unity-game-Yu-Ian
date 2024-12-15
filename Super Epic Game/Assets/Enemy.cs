using Unity.VisualScripting;
using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    private BattleManager bm;
    private GameObject player;
    private bool isPlayerClose = false;
    
    void Awake()
    {
        bm = GameObject.Find("BattleManager").GetComponent<BattleManager>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isPlayerClose) {
            Debug.Log("Player?????");
            bm.StartBattle(player, gameObject);
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
