using UnityEngine;

namespace Tutorial
{
    /// <summary>
    /// ��Ϸ��ڡ�
    /// </summary>
    public partial class GameEntry : MonoBehaviour
    {
        private void Start()
        {
            // ��ʼ���������
            InitBuiltinComponents();

            // ��ʼ���Զ������
            InitCustomComponents();

            // ��ʼ���Զ��������
            InitCustomDebuggers();
        }
    }
}