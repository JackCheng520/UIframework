using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

// ================================
//* 功能描述：GameUI_MainUI  
//* 创 建 者：chenghaixiao
//* 创建日期：2016/10/9 16:23:16
// ================================
namespace Assets.JackCheng.UI
{
    public class GameUI_MainUIContent : GameUIBaseContent {
        public GameUI_MainUIContent(UIType _uiType) 
            : base(_uiType){
    
        }
    }

    public class GameUI_MainUI : GameUIBaseView
    {
        public override void OnEnter(GameUIBaseContent _content)
        {
            base.OnEnter(_content);
            Debug.Log("MainUI Enter");
        }
        public override void OnExit(GameUIBaseContent _content)
        {
            base.OnExit(_content);
            Debug.Log("MainUI Exit");
        }

        public void OnClickUI1()
        {
            ContentManager.Ins.Push(new GameUI_UI1Content(UIType.UI1));
        }

        public void OnClickUI2()
        {
            ContentManager.Ins.Push(new GameUI_UI2Content(UIType.UI2));
        }
    }
}
