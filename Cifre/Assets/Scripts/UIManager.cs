using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject canvasSett, melodyGO;
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
        }
            
        else
        {
            melodyGO.SetActive(true);
        }
            
    }
}
