using UnityEngine;

public class BackgroundMover : MonoBehaviour
{
    [SerializeField] private Transform _removeTrigger;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private float _speed;

    private int direction = -1;

    private void Update()
    {       
        if(XDestinationReached(_removeTrigger.position.x))
            transform.position = _spawnPoint.position;
        Vector2 position = transform.position;
        position.x += _speed * direction * Time.deltaTime;
        transform.position = position;
    }

    private bool XDestinationReached(float destination)
    {
        if(transform.position.x <= destination)
            return true;
        return false;
    }
}
