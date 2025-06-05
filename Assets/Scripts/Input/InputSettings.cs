using UnityEngine;

public abstract class InputSettings : ScriptableObject
{
    //Basic fields Which is neccessary for control something

    public bool isUIControl = false;
    public float horizontalInput { get; protected set; } = 0;
    public float verticalInput { get; protected set; } = 0;
    public bool isRun { get; protected set; } = false;
    public bool isRoll { get; protected set; } = false;
    public bool isJump { get; protected set; } = false;
    public bool isMeleeAttackClicked { get; protected set; } = false;
    public bool isShooterAttackHold {  get; protected set; } = false;
    public bool isReloadClicked { get; protected set; } = false;
    public bool isBlockHold { get; protected set; } = false;
    public Vector2 cameraInput { get; protected set; }



    public abstract void Update();
}