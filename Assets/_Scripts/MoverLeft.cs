using UnityEngine;

public class MoverLeft : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _linearMover;
    [SerializeField] private float _offsetX;

    private void Update()
    {
        MoveLeft();
    }

    private void MoveLeft()
    {
        Vector2 position = transform.position;
        position.x = _linearMover.position.x + _offsetX;
        _offsetX -= _speed * Time.deltaTime;
        transform.position = position;
    }
}
