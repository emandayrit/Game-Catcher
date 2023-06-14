using UnityEngine;
using UnityEngine.Events;

public class EventListener : MonoBehaviour
{
    public ScoreEventHandler soEventHandler;
    public UnityEvent response;

    private void OnEnable()
    {
        soEventHandler.RegisterListener(this);
    }

    private void OnDisable()
    {
        soEventHandler.UnRegisterListener(this);
    }

    public void OnEventRaised()
    {
        response.Invoke();
    }
}
