using UnityEngine;
using System.Collections;

public class GUIEvents : MonoBehaviour {
    StateManager sm;
    void Start() {
        sm = FindObjectOfType<StateManager>();
    }       

    public void OnButtonClick(string name) {
        Debug.Log("OnButtonClick: " + name);
        if(sm != null) sm.OnGUIClick(name);

    }
}
