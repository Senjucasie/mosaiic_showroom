using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleClipping : MonoBehaviour
{
    public GameObject clippingSphere;
    public bool toggleBoolClipping;
    [SerializeField]
    private Transform _clipPoint;

    public void OnClipping()
    {
        toggleBoolClipping = !toggleBoolClipping;
        if(toggleBoolClipping)
        {
            clippingSphere.transform.position = _clipPoint.position;
        }
        clippingSphere.SetActive(toggleBoolClipping);
    }
}
