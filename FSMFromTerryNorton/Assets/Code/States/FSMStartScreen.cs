using UnityEngine;
using System.Collections;
using Assets.Code.Interfaces;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class FSMStartScreen : IStateBase {
    private StateManager manager;

    public FSMStartScreen(StateManager managerRef) {

        manager = managerRef;
        if (SceneManager.GetActiveScene().name  != "StartScreen")
        SceneManager.LoadScene("StartScreen");
    }

    public void OnGUIClick(string name) {
        switch (name) {
            case "OptionsButtonClick":
                manager.SwitchState(new FSMOptionsState(manager));
                break;
            case "StartGameButton":
                manager.SwitchState(new FSMGameState(manager));
                break;
        }
    }

    public void StateUpdate() {

    }
}
