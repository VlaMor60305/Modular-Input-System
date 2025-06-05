using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager instance;

    [SerializeField]public InputSettings inputSettings;

    public InputCanvas uiController;

    void Start()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }

        if (uiController != null)
        {
            uiController.gameObject.SetActive(inputSettings.isUIControl);
        }
        else
        {
            Debug.LogWarning("UI Controller is null!");
        }
    }

    void Update()
    {
        inputSettings.Update();
    }

    public void HotSwapSettings(InputSettings newSettings)
    {
        inputSettings = newSettings;
        Start();
    }
}
