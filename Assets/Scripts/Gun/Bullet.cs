using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _lifeTime;
    [SerializeField] private float _distance;
    [SerializeField] private int _damage;
    [SerializeField] private LayerMask _solidObjects;

    void Update()
    {
        if(_lifeTime <= 0)
        {
            Destroy(gameObject);
        }

        _lifeTime -= Time.deltaTime;

        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.right, _distance, _solidObjects);
        if(hitInfo.collider != null)
        {
            if (hitInfo.collider.CompareTag("Enemy"))
            {
                hitInfo.collider.GetComponent<Enemy>().TakeDamage(_damage);
            }
            Destroy(gameObject);
        }
        transform.Translate(Vector2.right * _speed * Time.deltaTime);
    }
}
