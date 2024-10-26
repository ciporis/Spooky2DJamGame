using System.Collections.Generic;
using UnityEngine;

public class VerticalMover : MonoBehaviour
{
    const string Vertical = nameof(Vertical);

    [SerializeField] private float _speed;
    [SerializeField] private float _offsetY;

    private void FixedUpdate()
    {
        float vertical = Input.GetAxis(Vertical);
        if(vertical > 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x, transform.position.y + _offsetY), _speed * Time.fixedDeltaTime);
        }
        if(vertical < 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x, transform.position.y - _offsetY), _speed * Time.fixedDeltaTime);
        }
    }
}   
