using UnityEngine;
using System.Collections;

namespace Assets.Code.Interfaces {
    public interface IStateBase {
        void StateUpdate();
        void OnGUIClick(string name);
    }
}