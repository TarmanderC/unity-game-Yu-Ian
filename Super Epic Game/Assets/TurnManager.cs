using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public BattleManager battleManager;
    private List<Character> allCharacters = new List<Character>();
    private Character currentCharacter;

    public PlayerActions pa;
    public AIController ac;

    public void StartBattle(Character[] characters) {

        // Adds all of the characters to the TurnManager's list to form the queue
        for (int i = 0; i < characters.Length; i++) {
            allCharacters.Add(characters[i]);
        }

        while (canContinueBattle()) {
            // Normalize the TU

            // Get the character with the lowest TU

            // if Player, show the buttons. If Enemies, do something AI idk

            // 
        }

    }

    public bool canContinueBattle() {
        return !isPlayersDead() && !isEnemiesDead();
    }

    public bool isPlayersDead() {

        for (int i = 0; i < allCharacters.Count; i++) {
            if (allCharacters[i] != null && allCharacters[i].isPlayer) {
                return false;
            }
        }

        return true;
    }

    public bool isEnemiesDead() {

        for (int i = 0; i < allCharacters.Count; i++) {
            if (allCharacters[i] != null && !allCharacters[i].isPlayer) {
                return false;
            }
        }

        return true;
    }
    
}
