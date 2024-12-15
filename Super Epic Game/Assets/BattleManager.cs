using UnityEngine;

public class BattleManager : MonoBehaviour
{
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

    public void StartBattle(GameObject player, GameObject enemy) {
        if (!isBattleActive) {
            isBattleActive = true;
            cameraTransform.position = new Vector3(-25,-25,-10);
            Debug.Log($"Battle started with {player.name} and {enemy.name}");
        }
    }

    public void EndBattle() {
        isBattleActive = false;
        cameraTransform.position = playerTransform.position;
        Debug.Log("Battle ended!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
