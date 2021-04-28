using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakerModels : MonoBehaviour
{
    public GameObject models;
    /* public GameObject chair;
     public GameObject stool;
     public GameObject jigsaw;
     public GameObject etron;*/
    public List<GameObject> products;

    void Awake()
    {
        gameObject.SetActive(false);
       /* chair.SetActive(false);
        stool.SetActive(false);
        jigsaw.SetActive(false);
        etron.SetActive(false);*/
        foreach(GameObject x in products )
        {
            x.SetActive(false);
        }

    }
}
