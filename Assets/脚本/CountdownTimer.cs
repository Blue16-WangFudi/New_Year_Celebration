using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro; // 引入TextMeshPro命名空间
using System;

public class CountdownTimer : MonoBehaviour
{
    public TextMeshPro countdownText; // 对TextMeshPro文本的引用

    void Update()
    {
        // 设定目标时间为2024年1月1日
        DateTime targetDate = new DateTime(2024, 1, 1, 0, 0, 0);
        // 计算当前时间与目标时间的差异
        TimeSpan timeDifference = targetDate - DateTime.Now;

        // 格式化字符串
        string countdownString = $"离2024年还剩{timeDifference.Days * 24 + timeDifference.Hours}小时{timeDifference.Minutes}分钟{timeDifference.Seconds}秒";
        // 更新UI文本
        countdownText.text = countdownString;
        // 如果按下ESC键，退出游戏
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit(); // 这将退出应用程序（仅在独立构建中有效）
        }
    }
}
