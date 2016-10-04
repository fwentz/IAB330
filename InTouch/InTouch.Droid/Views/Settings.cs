﻿using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace InTouch.Droid.Views
{
	[Activity(Label = "View for Settings")]
	public class Settings : MvxActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.Status);
		}
	}
}