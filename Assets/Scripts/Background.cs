using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField] private Transform _trigger;
    [SerializeField] private float _offsetX;

    private void Update()
    {
        if(transform.position.x == Mathf.Round(_trigger.position.x))
        {
            transform.position = new Vector2(transform.position.x + _offsetX, 0f);
        } 
    }

}
