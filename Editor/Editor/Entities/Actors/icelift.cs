using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindEditor.ViewModel;

namespace WindEditor
{
	public partial class icelift
	{
		public override void PostLoad()
		{
			UpdateModel();
			base.PostLoad();
		}

		public override void PreSave()
		{

		}

		private void UpdateModel()
		{
			m_actorMeshes.Clear();
			m_objRender = null;
			switch (Type)
            {
				case TypeEnum.Short_Ice_Platform:
					m_actorMeshes = WResourceManager.LoadActorResource("Short Ice Platform");
					break;
				case TypeEnum.Tall_Ice_Platform:
					m_actorMeshes = WResourceManager.LoadActorResource("Tall Ice Platform");
					break;
				default:
					m_objRender = WResourceManager.LoadObjResource("resources/editor/EditorCube.obj", new OpenTK.Vector4(1f, 1f, 1f, 1f));
					break;
			}
		}
	}
}
