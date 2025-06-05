using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed { get; private set; } = 5f;

    //Example of control character
    void LateUpdate()
    {
        Vector2 direction = new Vector2(InputManager.instance.inputSettings.horizontalInput , InputManager.instance.inputSettings.verticalInput).normalized;
        Vector3 movmentVector = new Vector3(direction.x, 0, direction.y);

        transform.Translate(movmentVector * speed * Time.deltaTime);
    }
}
