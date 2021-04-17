using TMPro;
using UnityEngine;


public class ItemsDisplayUI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private TextMeshPro _itemsUI;
    [SerializeField]
    private AwakerModels awakermodel;

    void Start()
    {
        _itemsUI.text = awakermodel.products.Count.ToString() + " Items";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
