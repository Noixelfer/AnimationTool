using DG.Tweening;
using UnityEngine;

namespace AnimationTool
{
	[RequireComponent(typeof(CanvasGroup))]
	public class FadeInAnimation : BaseAnimation
	{
		public float TransitionDuration = 1f;
		private CanvasGroup canvasGroup;
		private Tween tween;

		private CanvasGroup CanvasGroup
		{
			get
			{
				if (canvasGroup == null)
					canvasGroup = GetComponent<CanvasGroup>();
				return canvasGroup;
			}
		}

		public override void OnPanelInView()
		{
			base.OnPanelInView();
			CanvasGroup.alpha = 0f;
		}

		public override void OnStart()
		{
			base.OnStart();
			tween = CanvasGroup.DOFade(1f, TransitionDuration);
		}

		public override void OnEnd()
		{
			base.OnEnd();
			if (!tween.IsComplete())
			{
				tween.Complete();
				tween.Kill();
				tween = null;
			}
		}
	}
}