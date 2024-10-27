using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private float _speed;
    [SerializeField] private float _lifeTime;

    private void Update()
    {
        _lifeTime -= Time.deltaTime;
        if(_health <= 0 || _lifeTime <= 0)
        {
            Destroy(gameObject);    
        }
        MoveLeft();
    }

    private void MoveLeft()
    {
        Vector2 position = transform.position;
        position.x -= _speed * Time.deltaTime;
        transform.position = position;
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
    }
}
