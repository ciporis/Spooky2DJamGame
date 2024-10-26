using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;

    const string Vertical = nameof(Vertical);


    private void Update()
    {
        float vertical = Input.GetAxis(Vertical);
        if(vertical != 0)
            MoveVertical(vertical);
    }

    private void MoveVertical(float vertical)
    {
        Vector2 position = transform.position;
        position.y += 2 * vertical * Time.deltaTime;
        transform.position = position;
    }
}   
