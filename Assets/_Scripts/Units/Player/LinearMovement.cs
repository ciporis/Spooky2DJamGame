using UnityEngine;

public class LinearMovement : MonoBehaviour
{
    const string Vertical = nameof(Vertical);

    [SerializeField] private float _speed;

    private void FixedUpdate()
    {
        float vertical = Input.GetAxis(Vertical);
        
        Vector2 position = transform.position;
        position.y += _speed * vertical * Time.deltaTime;
        transform.position = position;
    }

}
