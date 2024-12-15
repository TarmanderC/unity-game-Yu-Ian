using UnityEngine;

public class BattleManager : MonoBehaviour
{
    private bool isBattleActive = false;
    public Transform cameraTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void StartBattle(GameObject player, GameObject enemy) {
        if (!isBattleActive) {
            isBattleActive = true;
            Debug.Log($"Battle started with {player.name} and {enemy.name}");
        }
    }

    public void EndBattle() {
        isBattleActive = false;
        Debug.Log("Battle ended!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
