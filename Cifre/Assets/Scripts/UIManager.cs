using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject canvasSett, melodyGO, melodyButtFake;
    public Sprite on, off;

    public void OffCanvasSett()
    {
        canvasSett.SetActive(false);
    }

    public void MelodyOffOn()
    {
        if (melodyGO.activeSelf)
        {
            melodyGO.SetActive(false);
            melodyButtFake.GetComponent<Image>().sprite = off;
        }
            
        else
        {
            melodyGO.SetActive(true);
            melodyButtFake.GetComponent<Image>().sprite = on;
        }
    }

    public void ReloadLevel()
    {
        SceneManager.LoadScene("Game");
    }
}
