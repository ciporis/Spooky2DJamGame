using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private float _offset;
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Transform _shotPoint;
    [SerializeField] private GameObject _sound;
    [SerializeField] private float _delay;

    private float _currentDelay;

    private void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotationZ + _offset);

        _currentDelay -= Time.deltaTime;

        if (Input.GetMouseButtonDown(0) && _currentDelay <= 0)
        {
            Instantiate(_sound, transform.position, Quaternion.identity);
            Instantiate(_bulletPrefab, _shotPoint.position, transform.rotation);
            _currentDelay = _delay;
        }
    }
}
