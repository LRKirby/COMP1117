using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.InputSystem;

// read input from the input system
public class PlayerInputHandler : MonoBehaviour
{
    private Vector2 moveInput;
    private bool jumpTriggered = false;

    // public properites
    public Vector2 MoveInput
    {
        get { return moveInput; }
    }

    public bool JumpTriggered
    {
        get { return jumpTriggered; }
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            jumpTriggered = true;
        }
        else if (context.canceled)
        {
            jumpTriggered = false;
        }
    }
}
