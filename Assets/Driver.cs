using UnityEngine;

public class Driver : MonoBehaviour
{
    private float _moveSpeed = 12.5f;
    private float _steerSpeed = 220;

    void Start()
    {

    }

    void LateUpdate()
    {
        float steerAmount = Input.GetAxis("Horizontal") * _steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
