using UnityEngine;
using System.Collections;
using Assets.Code.Interfaces;
using UnityEngine.SceneManagement;

public class FSMGameState : IStateBase {
    private StateManager manager;

    public FSMGameState(StateManager managerRef) {
        manager = managerRef;
        SceneManager.LoadScene("GameScreen");
    }

    public void OnGUIClick(string name) {
        switch (name) {
            case "EndGameButton":
                manager.SwitchState(new FSMStartScreen(manager));
                break;

        }
    }

    public void StateUpdate() {

    }
}
