using UnityEngine;

[CreateAssetMenu(fileName = "MobileInputSettings", menuName = "Input Settings/Mobile")]
public class MobileInput : InputSettings
{
    // variables which is necessary for this settings
    // It can be without any variables
    public override void Update()
    {
        horizontalInput = InputManager.instance.uiController.movmentJoustick.Horizontal;  
        verticalInput = InputManager.instance.uiController.movmentJoustick.Vertical;  
        
        //etc.
    }
}
