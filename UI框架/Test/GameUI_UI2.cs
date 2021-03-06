﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

// ================================
//* 功能描述：GameUI_UI1  
//* 创 建 者：chenghaixiao
//* 创建日期：2016/10/9 16:26:58
// ================================
namespace Assets.JackCheng.UI
{
    public class GameUI_UI2Content : GameUIBaseContent {
        public GameUI_UI2Content(UIType _uiType) :
            base(_uiType) { 
        
        }
    }
    public class GameUI_UI2 : GameUIBaseView
    {
        public override void OnEnter(GameUIBaseContent _content)
        {
            base.OnEnter(_content);
            Debug.Log("UI 2 Enter");
        }
        public override void OnExit(GameUIBaseContent _content)
        {
            base.OnExit(_content);
            Debug.Log("UI 2 Exit");
        }

        public void OnClickBack()
        {
            ContentManager.Ins.Pop();
        }
    }
}
