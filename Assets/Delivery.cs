using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] private Color32 _hasPackageColor = new Color32 (1, 1, 1, 1);
    [SerializeField] private Color32 _noPackageColor = new Color32(0, 1, 0, 1);

    [SerializeField] private float _destroyDelay = 0.5f;

    private bool _hasPackage = false;

    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !_hasPackage)
        {
            Debug.Log("Package pick up.");

            _hasPackage = true;
            _spriteRenderer.color = _hasPackageColor;

            Destroy(other.gameObject, _destroyDelay);
        }
        
        if(other.tag == "Customer" && _hasPackage)
        {
            Debug.Log("Package Delivered.");

            _hasPackage = false;
            _spriteRenderer.color = _noPackageColor;
        }
    }
}
