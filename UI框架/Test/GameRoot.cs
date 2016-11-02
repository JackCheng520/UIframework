using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

// ================================
//* 功能描述：GameRoot  
//* 创 建 者：chenghaixiao
//* 创建日期：2016/10/9 16:29:35
// ================================
namespace Assets.JackCheng.UI
{
    public class GameRoot : MonoBehaviour
    {
        void Awake() 
        {
            this.transform.DestroyAllChild();

            UIManager.Ins.Init();
            ContentManager.Ins.Init();

            ContentManager.Ins.Push(new GameUI_MainUIContent(UIType.mainUI));
        }


    }
}
