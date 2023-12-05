using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 12.5f;
    [SerializeField] private float _steerSpeed = 220;
    [SerializeField] private float _slowSpeed = 10;
    [SerializeField] private float _boostSpeed = 20;

    void LateUpdate()
    {
        float steerAmount = Input.GetAxis("Horizontal") * _steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        _moveSpeed = _slowSpeed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            _moveSpeed = _boostSpeed;
            Destroy(other.gameObject);
        }
    }
}
