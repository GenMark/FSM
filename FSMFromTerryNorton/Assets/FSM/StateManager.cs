using UnityEngine;
using Assets.Code.Interfaces;
using UnityEngine.SceneManagement;

public class StateManager : MonoBehaviour {
    private IStateBase activeState;

    private static StateManager instanceRef;

    void Awake() {
        if (instanceRef == null) {
            instanceRef = this;
            DontDestroyOnLoad(gameObject);
        } else {
            DestroyImmediate(gameObject);
          }
    }

    void Start() {
        activeState = new FSMStartScreen(this);
    }

    void Update() {
        if (activeState != null)
            activeState.StateUpdate();
    }

    public void OnGUIClick(string name) {
        if (activeState != null)
            activeState.OnGUIClick(name);
    }

    public void SwitchState(IStateBase newState) {
        Debug.Log("New State " + newState);
        activeState = newState;
    }

    public void Restart() {
        Destroy(gameObject);
        SceneManager.LoadScene("StartScreenScene");
    }
}

