using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// ================================
//* 功能描述：UIType  
//* 创 建 者：chenghaixiao
//* 创建日期：2016/10/9 15:15:27
// ================================
namespace Assets.JackCheng.UI
{
    public class UIType
    {
        public string Path{ get; private set;}

        public string UIName{ get; private set;}

        public UIType(string _path) {
            Path = _path;
            UIName = Path.Substring(_path.LastIndexOf("/") + 1);
        }


        public static readonly UIType mainUI = new UIType("UI/MainUIPrefab");
        public static readonly UIType UI1 = new UIType("UI/UI1Prefab");
        public static readonly UIType UI2 = new UIType("UI/UI2Prefab");
        public static readonly UIType UI3 = new UIType("UI/UI3Prefab");

    }
}
