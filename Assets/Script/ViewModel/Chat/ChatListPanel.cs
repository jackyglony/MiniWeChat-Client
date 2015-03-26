﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace MiniWeChat
{
    public class ChatListPanel : BasePanel
    {
        private const int CHAT_FRAME_HEIGHT = 200;

        public VerticalLayoutGroup _chatGrid;

        public void Start()
        {
            int chatNum = 10;
            _chatGrid.GetComponent<RectTransform>().sizeDelta = new Vector2(GlobalVars.DEFAULT_SCREEN_WIDTH, CHAT_FRAME_HEIGHT * chatNum);
            for (int i = 0; i < chatNum; i++)
            {
                GameObject go = UIManager.GetInstance().AddChild(_chatGrid.gameObject, EUIType.ChatFrame);
            }
        }

    }
}
