﻿using System;
using System.Linq;
using MonoTouch.UIKit;

namespace Screenmedia.IFTTT.JazzHands
{
	public class AlphaAnimation : Animation
	{
	    private void Animate(int time)
		{
			if (KeyFrames.Count() <= 1) return;

			AnimationFrame animationFrame = AnimationFrameForTime(time);
			View.Alpha = animationFrame.Alpha;
		}

		private AnimationFrame FrameForTime(int time,
			AnimationKeyFrame startKeyFrame,
			AnimationKeyFrame endKeyFrame)
		{
			AnimationFrame animationFrame = new AnimationFrame ();
			animationFrame.Alpha = TweenValueForStartTime (startKeyFrame.Time,
				endKeyFrame.Time,
				startKeyFrame.Alpha,
				endKeyFrame.Alpha,
				time);

			return animationFrame;
		}
	}
}

