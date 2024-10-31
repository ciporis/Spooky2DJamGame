using UnityEngine;
using UnityEngine.Events;

public class TimerBehaviour : MonoBehaviour
{
    [SerializeField] private float _duration = 1f;
    [SerializeField] private UnityEvent _onTimerEnd = null;

    private Timer _timer;

    private void Start()
    {
        _timer = new Timer(_duration);
    }

    private void OnEnable()
    {
        _timer.OnTimerEnd += HandleTimerEnd;
    }

    private void OnDisable()
    {
        _timer.OnTimerEnd -= HandleTimerEnd;
    }

    private void Update()
    {
        _timer.Tick(Time.deltaTime);
    }

    private void HandleTimerEnd()
    {
        _onTimerEnd?.Invoke();

        Destroy(this);
    }
}
