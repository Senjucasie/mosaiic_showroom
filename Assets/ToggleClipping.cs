using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleClipping : MonoBehaviour
{
    public GameObject clippingSphere;
   [SerializeField]
    private Transform _clipPoint;

    public void OnClippingEnable()
    {
        clippingSphere.SetActive(true);
        clippingSphere.transform.position = _clipPoint.position;
    }
    public void OnClippingDisable()
    {
        clippingSphere.SetActive(false);
        clippingSphere.transform.position = _clipPoint.position;
    }
}
