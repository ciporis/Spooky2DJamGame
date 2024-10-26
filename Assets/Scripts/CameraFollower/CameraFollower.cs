using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private Transform _linearMover;
    [SerializeField] private float _offsetX;

    private void Update()
    {
        MoveRight();
    }

    private void MoveRight()
    {
        Vector3 position = transform.position;
        position.x = _linearMover.position.x + _offsetX;
        transform.position = position;       
    }
}
