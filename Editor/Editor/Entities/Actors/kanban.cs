using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindEditor.ViewModel;
using WindEditor.Minitors;

namespace WindEditor
{
	public partial class kanban
	{
        private MessageReference m_MessageReference;

        [WProperty("Tag Msg", "Message ID", true, "The ID of the message to be displayed when the actor is interacted with.")]
        public MessageReference MessageReference
        {
            get { return m_MessageReference; }
            set
            {
                if (value != m_MessageReference)
                {
                    m_MessageReference = value;
                    MessageID = MessageReference.MessageID;
                    OnPropertyChanged("MessageReference");
                }
            }
        }

        public override void PostLoad()
		{
            m_actorMeshes = WResourceManager.LoadActorResource("Sign");
            VisualScaleMultiplier = new OpenTK.Vector3(0.8f);

            MessageReference = new MessageReference((ushort)MessageID);
		}

		public override void PreSave()
		{
            MessageID = MessageReference.MessageID;
		}
	}
}
