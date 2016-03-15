using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Animator))]
public class OptionDialog : MonoBehaviour {
    public static OptionDialog instance;
    Animator animator;

    void Awake() {
        instance = this;
        animator = GetComponent<Animator>();
    }

    public void Show() {
        if (animator != null)
            animator.SetBool("show", true);
    }

    public void Hide() {
        if(animator != null)
            animator.SetBool("show",false);
    }
}
