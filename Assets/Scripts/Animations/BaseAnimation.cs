using UnityEngine;

namespace AnimationTool
{
	public abstract class BaseAnimation : BaseBehaviour
	{
		public virtual void OnPanelInView() { }
		public virtual void OnStart() { }
		public virtual void OnEnd() { }
	}
}