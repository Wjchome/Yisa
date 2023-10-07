using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class smallUI : MonoBehaviour
{
    public TextMeshProUGUI[] textMeshProUGUIs;
    public PlayerData playerData;
    public Hurt hurt;

    private void Update()
    {
        textMeshProUGUIs[0].text = "金币：" + playerData.CodeNum;
        textMeshProUGUIs[1].text = "炸弹：" + playerData.BoomNum;
        textMeshProUGUIs[2].text = "钥匙：" + playerData.KeyNum;
        textMeshProUGUIs[3].text = "血量：" + hurt.HP;

    }
}
