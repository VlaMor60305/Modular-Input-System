using UnityEngine;

[CreateAssetMenu(fileName = "DesktopInputSettings", menuName = "Input Settings/Desktop")]
public class DesktopInput : InputSettings
{
    // Variables which is necessary for this settings
    // For example setting buttons for some action
    public KeyCode runningButton = KeyCode.LeftShift;
    public KeyCode rollingButton = KeyCode.LeftControl;
    public KeyCode jumpButton = KeyCode.Space;
    public KeyCode reloadButton = KeyCode.R;

    
    public override void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        isRun = Input.GetKey(runningButton);
        isRoll = Input.GetKey(rollingButton);
        isJump = Input.GetKey(jumpButton);

        isMeleeAttackClicked = Input.GetMouseButtonDown(0);

        cameraInput = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        isShooterAttackHold = Input.GetMouseButton(0);
        isBlockHold = Input.GetMouseButton(1);
        isReloadClicked = Input.GetKeyDown(reloadButton);
    }
}
