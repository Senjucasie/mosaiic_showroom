using Microsoft.MixedReality.Toolkit.Input;
using UnityEngine;

public class HandDragUpdate : MonoBehaviour, IMixedRealityPointerHandler
{

    public void OnPointerClicked(MixedRealityPointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnPointerDown(MixedRealityPointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnPointerDragged(MixedRealityPointerEventData eventData)
    {
        UpdatePosition();
    }

    public void OnPointerUp(MixedRealityPointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public GameObject UI;
    public GameObject UIPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public  void UpdatePosition()
    {
        UI.transform.position = UIPosition.transform.position;
    }
}
