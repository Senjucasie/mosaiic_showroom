using UnityEngine.UI;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Rendering;
using Microsoft.MixedReality.Toolkit.UI;

public class ColorSlider : MonoBehaviour
{
    public PinchSlider slider;

    // Drag & drop handle
   // public Image handle;
    public GameObject Object;

    public void Start()
    {
        slider.OnValueUpdated.AddListener(delegate { ValueChangeCheck(); });
    }

    // Invoked when the value of the slider changes.
    public void ValueChangeCheck()
    {
       // handle.color = Color.HSVToRGB(slider.SliderValue, 1, 1);
        Object.GetComponent<MaterialInstance>().Material.color = Color.HSVToRGB(slider.SliderValue, 1, 1);
    }
}
