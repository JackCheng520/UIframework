using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

// ================================
//* 功能描述：GameUIBaseView  
//* 创 建 者：chenghaixiao
//* 创建日期：2016/10/9 15:24:43
// ================================
namespace Assets.JackCheng.UI
{
    public class GameUIBaseView : MonoBehaviour
    {
        public virtual void OnEnter(GameUIBaseContent _content) { }

        public virtual void OnExit(GameUIBaseContent _content) { Destroy(); }

        public void Destroy()
        {
            if (gameObject != null)
                Destroy(gameObject);
        }
    }
}
