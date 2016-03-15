using UnityEngine;
using System.Collections;
using Assets.Code.Interfaces;

public class FSMOptionsState : IStateBase {
    private StateManager manager;

    void ShowOptionsDialog() {
        OptionDialog.instance.Show();
    }

    void HideOptionsDialog() {
        OptionDialog.instance.Hide();
    }

    public FSMOptionsState(StateManager managerRef) {
        manager = managerRef;
        ShowOptionsDialog();
    }

    public void OnGUIClick(string name) {
        switch (name) {
            case "SoundButton":
                break;
            case "MusikButton":
                break;
            case "ExitButton":
                HideOptionsDialog();
                manager.SwitchState(new FSMStartScreen(manager));
                break;
        }
    }

    public void StateUpdate() {

    }
}