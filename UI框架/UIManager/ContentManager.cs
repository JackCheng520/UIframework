using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// ================================
//* 功能描述：ContentManager  
//* 创 建 者：chenghaixiao
//* 创建日期：2016/10/9 15:35:43
// ================================
namespace Assets.JackCheng.UI
{
    public class ContentManager : JSington<ContentManager>
    {
        private Stack<GameUIBaseContent> stack = new Stack<GameUIBaseContent>();

        public void Init() { }

        public void Push(GameUIBaseContent _content) 
        {
            if (stack.Count > 0) {
                GameUIBaseContent cur = stack.Peek();
                GameUIBaseView view = UIManager.Ins.GetUI(cur.uiType).GetComponent<GameUIBaseView>();
                view.OnExit(cur);
            }
            GameUIBaseView nextView = UIManager.Ins.GetUI(_content.uiType).GetComponent<GameUIBaseView>();
            stack.Push(_content);
            nextView.OnEnter(_content);
        }

        public void Pop() {

            if (stack.Count > 0)
            {
                GameUIBaseContent cur = stack.Peek();
                stack.Pop();
                if (cur != null)
                {
                    GameUIBaseView view = UIManager.Ins.GetUI(cur.uiType).GetComponent<GameUIBaseView>();
                    view.OnExit(cur);
                }

                GameUIBaseContent pre = stack.Peek();
                if (pre != null)
                {
                    GameUIBaseView preView = UIManager.Ins.GetUI(pre.uiType).GetComponent<GameUIBaseView>();
                    preView.OnEnter(pre);
                }
            }
        }
    }
}
