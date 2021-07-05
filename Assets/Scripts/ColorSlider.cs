using UnityEngine.UI;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Rendering;

public class ColorSlider : MonoBehaviour
{
    public Slider slider;

    // Drag & drop handle
    public Image handle;
    public GameObject Object;

    public void Start()
    {
        slider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
    }

    // Invoked when the value of the slider changes.
    public void ValueChangeCheck()
    {
        handle.color = Color.HSVToRGB(slider.value, 1, 1);
        Object.GetComponent<MaterialInstance>().Material.color = handle.color;
    }
}
