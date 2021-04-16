using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakerModels : MonoBehaviour
{
    public GameObject models;
    public GameObject chair;
    public GameObject stool;
    public GameObject jigsaw;
    public GameObject etron;


    void Awake()
    {
        models.SetActive(false);
        chair.SetActive(false);
        stool.SetActive(false);
        jigsaw.SetActive(false);
        etron.SetActive(false);

    }
}
