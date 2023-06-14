using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Scriptable Object/Event Handler")]
public class SOEvent : ScriptableObject
{
    public List<EventListener> listeners = new List<EventListener>();

    public void Raise()
    {
        for (int i = 0; i < listeners.Count; i++)
        {
            listeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(EventListener listener)
    {
        if (!listeners.Contains(listener))
        {
            listeners.Add(listener);
        }
    }

    public void UnRegisterListener(EventListener listener)
    {
        if (listeners.Contains(listener))
        {
            listeners.Remove(listener);
        }
    }
}
