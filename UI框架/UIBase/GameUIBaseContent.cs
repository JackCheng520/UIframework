using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// ================================
//* 功能描述：GameUIContent  
//* 创 建 者：chenghaixiao
//* 创建日期：2016/10/9 15:10:54
// ================================
namespace Assets.JackCheng.UI
{
    public class GameUIBaseContent 
    {
        public UIType uiType { get; private set; }
        public GameUIBaseContent(UIType _uiType) 
        {
            uiType = _uiType;
        }
    }
}
