using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro; // ����TextMeshPro�����ռ�
using System;

public class CountdownTimer : MonoBehaviour
{
    public TextMeshPro countdownText; // ��TextMeshPro�ı�������

    void Update()
    {
        // �趨Ŀ��ʱ��Ϊ2024��1��1��
        DateTime targetDate = new DateTime(2024, 1, 1, 0, 0, 0);
        // ���㵱ǰʱ����Ŀ��ʱ��Ĳ���
        TimeSpan timeDifference = targetDate - DateTime.Now;

        // ��ʽ���ַ���
        string countdownString = $"��2024�껹ʣ{timeDifference.Days * 24 + timeDifference.Hours}Сʱ{timeDifference.Minutes}����{timeDifference.Seconds}��";
        // ����UI�ı�
        countdownText.text = countdownString;
        // �������ESC�����˳���Ϸ
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit(); // �⽫�˳�Ӧ�ó��򣨽��ڶ�����������Ч��
        }
    }
}
