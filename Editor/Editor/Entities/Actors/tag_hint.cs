using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindEditor.ViewModel;
using OpenTK;
using WindEditor.Minitors;

namespace WindEditor
{
	public partial class tag_hint
	{
        private MessageReference m_MessageReference;

        [WProperty("Tag Hint", "Message ID", true, "The ID of the message to be displayed when the actor is interacted with.")]
        public MessageReference MessageReference
        {
            get { return m_MessageReference; }
            set
            {
                if (m_MessageReference != value)
                {
                    m_MessageReference = value;
                    MessageID = MessageReference.MessageID;
                    OnPropertyChanged("MessageReference");
                }
            }
        }

        public override void PostLoad()
        {
            m_RegionAreaModel = WResourceManager.LoadObjResource("resources/editor/EditorCylinder.obj", new Vector4(1f, 1f, 0f, 1f), true, false);
            m_objRender = WResourceManager.LoadObjResource("resources/editor/EditorCube.obj", new Vector4(1f, 1f, 0f, 1f));

            m_MessageReference = new MessageReference((ushort)MessageID);
        }

        public override void PreSave()
        {
            MessageID = MessageReference.MessageID;
        }

        protected override Vector3 VisualScale
        {
            get { return Vector3.Multiply(new Vector3(Transform.LocalScale.X, Transform.LocalScale.Y, Transform.LocalScale.X), VisualScaleMultiplier); }
        }
    }
}
