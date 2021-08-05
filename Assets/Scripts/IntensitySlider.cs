using Microsoft.MixedReality.Toolkit.Rendering;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;


public class IntensitySlider : MonoBehaviour
{
    public PinchSlider slider;
    public GameObject Object;
    float _testValue=0;
    // Start is called before the first frame update
    void Start()
    {
        slider.OnValueUpdated.AddListener(delegate { ValueChangeCheck(); });
    }

    public void ValueChangeCheck()
    {
        _testValue = 1 - slider.SliderValue;
        Object.GetComponent<MaterialInstance>().Material.SetFloat("_Metallic", _testValue);
    }

}

