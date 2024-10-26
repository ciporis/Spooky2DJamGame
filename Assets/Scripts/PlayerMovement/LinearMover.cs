using UnityEngine;

public class LinearMover : MonoBehaviour
{
    [SerializeField] public float _speed;

    private void Update()
    {
        MoveRight();
    }

    private void MoveRight()
    {
        Vector2 position = transform.position;
        position.x += _speed * Time.deltaTime;
        transform.position = position;
    }
}