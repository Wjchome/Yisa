using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OneUI : MonoBehaviour
{
    public Control control;
    public PlayerData playerData;

    public GameObject[] images;

    private void OnEnable()
    {
        for (int i = 0; i < playerData.道具.Length; i++)
        {
            if (playerData.道具[i] != 0)
            {
                images[i].SetActive(true);
                images[i].GetComponent<Image>().sprite = playerData.sprites[i];
            }
        }
    }
    public void 退出游戏()
    {
        Application.Quit();
    }


    public void 重新开始()
    {
        control.IsPause = false;
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
        gameObject.SetActive(false);

    }


    public void 返回()
    {

        control.IsPause = false;
        Time.timeScale = 1;
        gameObject.SetActive(false);

    }
}
