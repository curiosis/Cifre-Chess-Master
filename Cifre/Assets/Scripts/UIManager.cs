using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject canvasSett, melodyGO, melodyButtFake, canvasDictView;
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
        GameManager.turnValue = 0;
        GameManager.whiteScore = 0;
        GameManager.blackScore = 0;
        GameManager.whiteWinByPieces = 0;
        SceneManager.LoadScene("Game");
    }

    public void Home()
    {
        SceneManager.LoadScene("TitleScreen");
    }

    public void CanvasDictViewOn()
    {
        canvasDictView.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
