using Microsoft.MixedReality.Toolkit.Input;
using UnityEngine;
using System.Collections.Generic;

public class DoubleTap : MonoBehaviour, IMixedRealityPointerHandler
{
    [SerializeField]
    private float _currentDelay = 0, _maxDelay = 1;
    [SerializeField]
    private bool _Timer = false;
    public GameObject Tools;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_Timer)
        {
            _currentDelay += Time.deltaTime;
            if (_currentDelay >= _maxDelay)
            {
                resettimer();
            }
        }
    }

    

    public void singletap()
    {
        Debug.Log("Singletap");
    }
    public void doubletap()
    {
        Debug.Log("Doubletap");
        if (!Tools.activeInHierarchy)
            Tools.SetActive(true);
    }
    private void resettimer()
    {
        _currentDelay = 0;
        _Timer = false;
    }

    public void OnPointerDown(MixedRealityPointerEventData eventData)
    {
        //Debug.Log("OnPointerDown");
    }

    public void OnPointerDragged(MixedRealityPointerEventData eventData)
    {
      //  Debug.Log("OnPointerDragged");
    }

    public void OnPointerUp(MixedRealityPointerEventData eventData)
    {
        //Debug.Log("OnPointerUp");
        
        //if (!_Timer)
        //{
        //    _Timer = true;
        //    Invoke("singletap", 1f);
        //}
        //else
        //{
        //    CancelInvoke("singletap");
        //    doubletap();
        //}
    }

    public void OnPointerClicked(MixedRealityPointerEventData eventData)
    {
        if (!_Timer)
        {
            _Timer = true;
            Invoke("singletap", 1f);
        }
        else
        {
            CancelInvoke("singletap");
            doubletap();
        }
    }
}
