using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(EventTrigger))]
public class FlexibleDraggableWindow : MonoBehaviour
{
    public GameObject Target;
    private EventTrigger _eventTrigger;
    void Start()
    {
        _eventTrigger = GetComponent<EventTrigger>();
        var entry = new EventTrigger.Entry();
        entry.callback = new EventTrigger.TriggerEvent();
        entry.callback.AddListener(OnDrag);// += OnDrag;
        entry.eventID = EventTriggerType.Drag;

        _eventTrigger.triggers.Add(entry);
    }

    void OnDrag(BaseEventData data)
    {
        PointerEventData ped = (PointerEventData)data;
        Target.transform.Translate(ped.delta);
    }
}
