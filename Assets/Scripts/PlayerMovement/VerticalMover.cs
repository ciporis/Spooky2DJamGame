using UnityEngine;

public class VerticalMover : MonoBehaviour
{
    const string Vertical = nameof(Vertical);

    [SerializeField] private float _speed;
    [SerializeField] private float _offsetY;

    private void FixedUpdate()
    {
        float vertical = Input.GetAxis(Vertical);
        if (vertical > 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x, transform.position.y + _offsetY), _speed * Time.fixedDeltaTime);
        }
        if (vertical < 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x, transform.position.y - _offsetY), _speed * Time.fixedDeltaTime);
        }
    }

    //private void Update()
    //{
    //    transform.position = Vector2.MoveTowards(transform.position, _targetPosition, _speedY * Time.deltaTime);

    //    Vector2 position = transform.position;
    //    position.x += _speedX * Time.deltaTime;
    //    transform.position = position;

    //    if (Input.GetKeyDown(KeyCode.W) && transform.position.y < _maxY)
    //    {
    //        _targetPosition = new Vector2(transform.position.x, transform.position.y + _offsetY);
    //    }
    //    else if(Input.GetKeyDown(KeyCode.S) && transform.position.y > _minY)
    //    {
    //        _targetPosition = new Vector2(transform.position.x, transform.position.y - _offsetY);
    //    }
    //}
}   
