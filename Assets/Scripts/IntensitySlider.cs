using Microsoft.MixedReality.Toolkit.Rendering;
using UnityEngine;
using UnityEngine.UI;

public class IntensitySlider : MonoBehaviour
{
    public Slider slider;
    public GameObject Object;
    // Start is called before the first frame update
    void Start()
    {
        slider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
    }

    public void ValueChangeCheck()
    {

        Object.GetComponent<MaterialInstance>().Material.SetFloat("_Metallic", slider.value);
    }

}

