
using UnityEngine;
using UnityEngine.InputSystem;

public class HandScript : MonoBehaviour
{
    public InputActionReference grapInput;
    public InputActionReference triggerInput;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (!animator) return;
        float grap = grapInput.action.ReadValue<float>();
        float trigger = triggerInput.action.ReadValue<float>();
        animator.SetFloat("Grab", grap);
        animator.SetFloat("Trigger", trigger);
    }
}
