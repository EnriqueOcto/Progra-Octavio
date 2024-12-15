using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HabilitySelection : MonoBehaviour
{
    public GameObject rifle;
    public GameObject escopeta;
    public GameObject pistola;
    private bool isRifleActive;
    private bool isEscopetaActive;

    void Start()
    {
        rifle.SetActive(true);
        escopeta.SetActive(false);
        pistola.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            rifle.SetActive(true);
            escopeta.SetActive(false);
            pistola.SetActive(false);
            SoundManager.PlaySound(SoundType.CAMBIOARMA);
        }

        if (Input.GetKeyDown("2"))
        {
            escopeta.SetActive(true);
            rifle.SetActive(false);
            pistola.SetActive(false);
            SoundManager.PlaySound(SoundType.CAMBIOARMA);
        }

        if (Input.GetKeyDown("3"))
        {
            escopeta.SetActive(false);
            rifle.SetActive(false);
            pistola.SetActive(true);
            SoundManager.PlaySound(SoundType.CAMBIOARMA);
        }
    }
}
