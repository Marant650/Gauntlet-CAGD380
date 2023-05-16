using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventBus : MonoBehaviour
{
    private static readonly IDictionary<PowerupEvent, UnityEvent> Events = new Dictionary<PowerupEvent, UnityEvent>();

    public static void Subscribe(PowerupEvent GBevent, UnityAction listener)
    {
        UnityEvent thisEvent;

        if (Events.TryGetValue(GBevent, out thisEvent))
        {
            thisEvent.AddListener(listener);
        }
        else
        {
            thisEvent = new UnityEvent();
            thisEvent.AddListener(listener);
            Events.Add(GBevent, thisEvent);
        }
    }

    public static void Unsubscribe(PowerupEvent type, UnityAction listener)
    {
        UnityEvent thisEvent;

        if (Events.TryGetValue(type, out thisEvent))
        {
            thisEvent.RemoveListener(listener);
        }

    }

    public static void Publish(PowerupEvent type)
    {
        UnityEvent thisEvent;

        if (Events.TryGetValue(type, out thisEvent))
        {
            thisEvent.Invoke();
        }
    }
}
